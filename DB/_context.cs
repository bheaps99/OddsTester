using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Configuration;

#nullable disable

namespace First12.DB
{
    public partial class _context : DbContext
    {
        public _context()
        {
        }

        public _context(DbContextOptions<_context> options)
            : base(options)
        {
        }

        public virtual DbSet<EtfReference> EtfReferences { get; set; }
        public virtual DbSet<EventLogger> EventLoggers { get; set; }
        public virtual DbSet<MasterResultsTable> MasterResultsTables { get; set; }
        public virtual DbSet<MasterSourceScoringTable> MasterSourceScoringTables { get; set; }
        public virtual DbSet<MasterStockDatum> MasterStockData { get; set; }
        public virtual DbSet<MasterSymbolList> MasterSymbolLists { get; set; }
        public virtual DbSet<RawStockEod3yr> RawStockEod3yrs { get; set; }
        public virtual DbSet<RawStockIqfeed3yr> RawStockIqfeed3yrs { get; set; }
        public virtual DbSet<RawStockPolygon3yr> RawStockPolygon3yrs { get; set; }
        public virtual DbSet<RawStockScoringTable> RawStockScoringTables { get; set; }
        public virtual DbSet<RawStockTiingo3yr> RawStockTiingo3yrs { get; set; }
        public virtual DbSet<ReferenceMapping> ReferenceMappings { get; set; }
        public virtual DbSet<ReferenceMappingOld0612> ReferenceMappingOld0612s { get; set; }
        public virtual DbSet<ReferenceSecurity> ReferenceSecurities { get; set; }
        public virtual DbSet<StocksAddedRenamed20200819> StocksAddedRenamed20200819s { get; set; }
        public virtual DbSet<StocksAddedRenamed20200903> StocksAddedRenamed20200903s { get; set; }
        public virtual DbSet<StocksRemoved20200727> StocksRemoved20200727s { get; set; }
        public virtual DbSet<StocksRemoved20200819> StocksRemoved20200819s { get; set; }
        public virtual DbSet<StocksRemoved20200903> StocksRemoved20200903s { get; set; }
        public virtual DbSet<StocksRemovedMeeting> StocksRemovedMeetings { get; set; }
        public virtual DbSet<StocksRemovedStoredProc> StocksRemovedStoredProcs { get; set; }
        public virtual DbSet<StocksRenamedStoredProc> StocksRenamedStoredProcs { get; set; }
        public virtual DbSet<SymbolListEod> SymbolListEods { get; set; }
        public virtual DbSet<SymbolListIqfeed> SymbolListIqfeeds { get; set; }
        public virtual DbSet<SymbolListPolygon> SymbolListPolygons { get; set; }
        public virtual DbSet<SymbolListTiingo> SymbolListTiingos { get; set; }
        public virtual DbSet<UpdateChngfromprevRef> UpdateChngfromprevRefs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["StockContext"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EtfReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ETF_REFERENCE", "STAGE");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ASSET_CLASS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<EventLogger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EVENT_LOGGER", "STAGE");

                entity.Property(e => e.ErrorLogTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ERROR_LOG_TIME");

                entity.Property(e => e.ErrorMessage).HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.Event)
                    .HasMaxLength(50)
                    .HasColumnName("EVENT");

                entity.Property(e => e.EventDuration).HasColumnName("EVENT_DURATION");

                entity.Property(e => e.EventStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("EVENT_START_TIME");

                entity.Property(e => e.LoggerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LOGGER_ID");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .HasColumnName("SOURCE");
            });

            modelBuilder.Entity<MasterResultsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_RESULTS_TABLE", "STAGE");

                entity.HasIndex(e => new { e.Symbol, e.Date }, "ClusteredIndex-SYMBOL-DATE-20200614")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.Date, "NonClusteredIndex-DATE-20200614");

                entity.Property(e => e.Bucket)
                    .HasMaxLength(100)
                    .HasColumnName("BUCKET");

                entity.Property(e => e.ChngfromprevE).HasColumnName("CHNGFROMPREV_E");

                entity.Property(e => e.ChngfromprevI).HasColumnName("CHNGFROMPREV_I");

                entity.Property(e => e.ChngfromprevP).HasColumnName("CHNGFROMPREV_P");

                entity.Property(e => e.ChngfromprevRef).HasColumnName("CHNGFROMPREV_REF");

                entity.Property(e => e.ChngfromprevT).HasColumnName("CHNGFROMPREV_T");

                entity.Property(e => e.ChngprevE).HasColumnName("CHNGPREV_E");

                entity.Property(e => e.ChngprevI).HasColumnName("CHNGPREV_I");

                entity.Property(e => e.ChngprevP).HasColumnName("CHNGPREV_P");

                entity.Property(e => e.ChngprevT).HasColumnName("CHNGPREV_T");

                entity.Property(e => e.ChooseE).HasColumnName("CHOOSE_E");

                entity.Property(e => e.ChooseI).HasColumnName("CHOOSE_I");

                entity.Property(e => e.ChooseP).HasColumnName("CHOOSE_P");

                entity.Property(e => e.ChooseT).HasColumnName("CHOOSE_T");

                entity.Property(e => e.Close).HasColumnName("CLOSE");

                entity.Property(e => e.CloseE).HasColumnName("CLOSE_E");

                entity.Property(e => e.CloseI).HasColumnName("CLOSE_I");

                entity.Property(e => e.CloseP).HasColumnName("CLOSE_P");

                entity.Property(e => e.CloseT).HasColumnName("CLOSE_T");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Diff100E).HasColumnName("DIFF100_E");

                entity.Property(e => e.Diff100I).HasColumnName("DIFF100_I");

                entity.Property(e => e.Diff100P).HasColumnName("DIFF100_P");

                entity.Property(e => e.Diff100T).HasColumnName("DIFF100_T");

                entity.Property(e => e.DifffrommedE).HasColumnName("DIFFFROMMED_E");

                entity.Property(e => e.DifffrommedI).HasColumnName("DIFFFROMMED_I");

                entity.Property(e => e.DifffrommedP).HasColumnName("DIFFFROMMED_P");

                entity.Property(e => e.DifffrommedT).HasColumnName("DIFFFROMMED_T");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.FlagCriterion)
                    .HasMaxLength(100)
                    .HasColumnName("FLAG_CRITERION");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.HighE).HasColumnName("HIGH_E");

                entity.Property(e => e.HighI).HasColumnName("HIGH_I");

                entity.Property(e => e.HighP).HasColumnName("HIGH_P");

                entity.Property(e => e.HighT).HasColumnName("HIGH_T");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.LowE).HasColumnName("LOW_E");

                entity.Property(e => e.LowI).HasColumnName("LOW_I");

                entity.Property(e => e.LowP).HasColumnName("LOW_P");

                entity.Property(e => e.LowT).HasColumnName("LOW_T");

                entity.Property(e => e.Match1E).HasColumnName("MATCH1_E");

                entity.Property(e => e.Match1I).HasColumnName("MATCH1_I");

                entity.Property(e => e.Match1P).HasColumnName("MATCH1_P");

                entity.Property(e => e.Match1T).HasColumnName("MATCH1_T");

                entity.Property(e => e.Match2E).HasColumnName("MATCH2_E");

                entity.Property(e => e.Match2I).HasColumnName("MATCH2_I");

                entity.Property(e => e.Match2P).HasColumnName("MATCH2_P");

                entity.Property(e => e.Match2T).HasColumnName("MATCH2_T");

                entity.Property(e => e.Match3E).HasColumnName("MATCH3_E");

                entity.Property(e => e.Match3I).HasColumnName("MATCH3_I");

                entity.Property(e => e.Match3P).HasColumnName("MATCH3_P");

                entity.Property(e => e.Match3T).HasColumnName("MATCH3_T");

                entity.Property(e => e.Median).HasColumnName("MEDIAN");

                entity.Property(e => e.Minmaxrange).HasColumnName("MINMAXRANGE");

                entity.Property(e => e.Minmaxrangespread).HasColumnName("MINMAXRANGESPREAD");

                entity.Property(e => e.NomatchE).HasColumnName("NOMATCH_E");

                entity.Property(e => e.NomatchI).HasColumnName("NOMATCH_I");

                entity.Property(e => e.NomatchP).HasColumnName("NOMATCH_P");

                entity.Property(e => e.NomatchT).HasColumnName("NOMATCH_T");

                entity.Property(e => e.NovalueE).HasColumnName("NOVALUE_E");

                entity.Property(e => e.NovalueI).HasColumnName("NOVALUE_I");

                entity.Property(e => e.NovalueP).HasColumnName("NOVALUE_P");

                entity.Property(e => e.NovalueT).HasColumnName("NOVALUE_T");

                entity.Property(e => e.Open).HasColumnName("OPEN");

                entity.Property(e => e.OpenE).HasColumnName("OPEN_E");

                entity.Property(e => e.OpenI).HasColumnName("OPEN_I");

                entity.Property(e => e.OpenP).HasColumnName("OPEN_P");

                entity.Property(e => e.OpenT).HasColumnName("OPEN_T");

                entity.Property(e => e.RecommendedSource)
                    .HasMaxLength(10)
                    .HasColumnName("RECOMMENDED_SOURCE");

                entity.Property(e => e.ReliabilityE).HasColumnName("RELIABILITY_E");

                entity.Property(e => e.ReliabilityI).HasColumnName("RELIABILITY_I");

                entity.Property(e => e.ReliabilityP).HasColumnName("RELIABILITY_P");

                entity.Property(e => e.ReliabilityT).HasColumnName("RELIABILITY_T");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.SymbolE)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_E");

                entity.Property(e => e.SymbolI)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_I");

                entity.Property(e => e.SymbolP)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_P");

                entity.Property(e => e.SymbolT)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_T");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.TrE).HasColumnName("TR_E");

                entity.Property(e => e.TrI).HasColumnName("TR_I");

                entity.Property(e => e.TrP).HasColumnName("TR_P");

                entity.Property(e => e.TrT).HasColumnName("TR_T");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");

                entity.Property(e => e.VolumeE).HasColumnName("VOLUME_E");

                entity.Property(e => e.VolumeI).HasColumnName("VOLUME_I");

                entity.Property(e => e.VolumeP).HasColumnName("VOLUME_P");

                entity.Property(e => e.VolumeT).HasColumnName("VOLUME_T");
            });

            modelBuilder.Entity<MasterSourceScoringTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_SOURCE_SCORING_TABLE", "STOCKODDS");

                entity.HasIndex(e => e.Date, "nci_wi_MASTER_SOURCE_SCORING_TABLE_9CD4B95A5FA9624F4C102168DAD20A55");

                entity.Property(e => e.ChngfromprevE)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CHNGFROMPREV_E");

                entity.Property(e => e.ChngfromprevI)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CHNGFROMPREV_I");

                entity.Property(e => e.ChngfromprevRef)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CHNGFROMPREV_REF");

                entity.Property(e => e.ChngfromprevT)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CHNGFROMPREV_T");

                entity.Property(e => e.ChngprevE).HasColumnName("CHNGPREV_E");

                entity.Property(e => e.ChngprevI).HasColumnName("CHNGPREV_I");

                entity.Property(e => e.ChngprevT).HasColumnName("CHNGPREV_T");

                entity.Property(e => e.Close)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE");

                entity.Property(e => e.CloseE).HasColumnName("CLOSE_E");

                entity.Property(e => e.CloseE2)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE_E_2");

                entity.Property(e => e.CloseI).HasColumnName("CLOSE_I");

                entity.Property(e => e.CloseI2)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE_I_2");

                entity.Property(e => e.ClosePd2)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE_PD_2");

                entity.Property(e => e.CloseRef)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE_REF");

                entity.Property(e => e.CloseT).HasColumnName("CLOSE_T");

                entity.Property(e => e.CloseT2)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE_T_2");

                entity.Property(e => e.CloseprevRef)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSEPREV_REF");

                entity.Property(e => e.CorrCoeff).HasColumnName("CORR_COEFF");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.DodMoveE)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DOD_MOVE_E");

                entity.Property(e => e.DodMoveI)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DOD_MOVE_I");

                entity.Property(e => e.DodMoveT)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("DOD_MOVE_T");

                entity.Property(e => e.FlagDodMoveE).HasColumnName("FLAG_DOD_MOVE_E");

                entity.Property(e => e.FlagDodMoveI).HasColumnName("FLAG_DOD_MOVE_I");

                entity.Property(e => e.FlagDodMoveT).HasColumnName("FLAG_DOD_MOVE_T");

                entity.Property(e => e.FlagSplitE).HasColumnName("FLAG_SPLIT_E");

                entity.Property(e => e.FlagSplitT).HasColumnName("FLAG_SPLIT_T");

                entity.Property(e => e.High)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("HIGH");

                entity.Property(e => e.HighE).HasColumnName("HIGH_E");

                entity.Property(e => e.HighI).HasColumnName("HIGH_I");

                entity.Property(e => e.HighT).HasColumnName("HIGH_T");

                entity.Property(e => e.Low)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("LOW");

                entity.Property(e => e.LowE).HasColumnName("LOW_E");

                entity.Property(e => e.LowI).HasColumnName("LOW_I");

                entity.Property(e => e.LowT).HasColumnName("LOW_T");

                entity.Property(e => e.Match1E).HasColumnName("MATCH1_E");

                entity.Property(e => e.Match1I).HasColumnName("MATCH1_I");

                entity.Property(e => e.Match1T).HasColumnName("MATCH1_T");

                entity.Property(e => e.Match2E).HasColumnName("MATCH2_E");

                entity.Property(e => e.Match2I).HasColumnName("MATCH2_I");

                entity.Property(e => e.Match2T).HasColumnName("MATCH2_T");

                entity.Property(e => e.Max33).HasColumnName("max33");

                entity.Property(e => e.Max50).HasColumnName("max50");

                entity.Property(e => e.Min33).HasColumnName("min33");

                entity.Property(e => e.Min50).HasColumnName("min50");

                entity.Property(e => e.NomatchE).HasColumnName("NOMATCH_E");

                entity.Property(e => e.NomatchI).HasColumnName("NOMATCH_I");

                entity.Property(e => e.NomatchT).HasColumnName("NOMATCH_T");

                entity.Property(e => e.NovalueE).HasColumnName("NOVALUE_E");

                entity.Property(e => e.NovalueI).HasColumnName("NOVALUE_I");

                entity.Property(e => e.NovalueT).HasColumnName("NOVALUE_T");

                entity.Property(e => e.Open)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("OPEN");

                entity.Property(e => e.OpenE).HasColumnName("OPEN_E");

                entity.Property(e => e.OpenI).HasColumnName("OPEN_I");

                entity.Property(e => e.OpenT).HasColumnName("OPEN_T");

                entity.Property(e => e.ReferenceEtf)
                    .HasMaxLength(10)
                    .HasColumnName("REFERENCE_ETF");

                entity.Property(e => e.Rr1E).HasColumnName("RR1_E");

                entity.Property(e => e.Rr1I).HasColumnName("RR1_I");

                entity.Property(e => e.Rr1T).HasColumnName("RR1_T");

                entity.Property(e => e.Rr2E).HasColumnName("RR2_E");

                entity.Property(e => e.Rr2I).HasColumnName("RR2_I");

                entity.Property(e => e.Rr2T).HasColumnName("RR2_T");

                entity.Property(e => e.ScoreMatch1E).HasColumnName("SCORE_MATCH1_E");

                entity.Property(e => e.ScoreMatch1I).HasColumnName("SCORE_MATCH1_I");

                entity.Property(e => e.ScoreMatch1T).HasColumnName("SCORE_MATCH1_T");

                entity.Property(e => e.SigDiff).HasColumnName("SIG_DIFF");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.SourceBucket)
                    .HasMaxLength(100)
                    .HasColumnName("SOURCE_BUCKET");

                entity.Property(e => e.SourceFlag).HasColumnName("SOURCE_FLAG");

                entity.Property(e => e.SourceScore).HasColumnName("SOURCE_SCORE");

                entity.Property(e => e.SourceTotalE).HasColumnName("SOURCE_TOTAL_E");

                entity.Property(e => e.SourceTotalI).HasColumnName("SOURCE_TOTAL_I");

                entity.Property(e => e.SourceTotalT).HasColumnName("SOURCE_TOTAL_T");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("TR");

                entity.Property(e => e.TrE).HasColumnName("TR_E");

                entity.Property(e => e.TrI).HasColumnName("TR_I");

                entity.Property(e => e.TrT).HasColumnName("TR_T");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");

                entity.Property(e => e.VolumeE).HasColumnName("VOLUME_E");

                entity.Property(e => e.VolumeI).HasColumnName("VOLUME_I");

                entity.Property(e => e.VolumeT).HasColumnName("VOLUME_T");
            });

            modelBuilder.Entity<MasterStockDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_STOCK_DATA", "STOCKODDS");

                entity.Property(e => e.Close)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("CLOSE");

                entity.Property(e => e.CorrCoeff).HasColumnName("CORR_COEFF");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.FlagDodMoveE).HasColumnName("FLAG_DOD_MOVE_E");

                entity.Property(e => e.FlagDodMoveI).HasColumnName("FLAG_DOD_MOVE_I");

                entity.Property(e => e.FlagDodMoveT).HasColumnName("FLAG_DOD_MOVE_T");

                entity.Property(e => e.FlagSplitE).HasColumnName("FLAG_SPLIT_E");

                entity.Property(e => e.FlagSplitT).HasColumnName("FLAG_SPLIT_T");

                entity.Property(e => e.High)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("HIGH");

                entity.Property(e => e.Low)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("LOW");

                entity.Property(e => e.Open)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("OPEN");

                entity.Property(e => e.ReferenceEtf)
                    .HasMaxLength(10)
                    .HasColumnName("REFERENCE_ETF");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.SourceBucket)
                    .HasMaxLength(100)
                    .HasColumnName("SOURCE_BUCKET");

                entity.Property(e => e.SourceScore).HasColumnName("SOURCE_SCORE");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("TR");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<MasterSymbolList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_SYMBOL_LIST", "STOCKODDS");

                entity.Property(e => e.Currentflag).HasColumnName("CURRENTFLAG");

                entity.Property(e => e.Deletedflag).HasColumnName("DELETEDFLAG");

                entity.Property(e => e.Effectivefromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVEFROMDATE");

                entity.Property(e => e.Effectivetodate)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFECTIVETODATE");

                entity.Property(e => e.Etf).HasColumnName("ETF");

                entity.Property(e => e.Etn).HasColumnName("ETN");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(50)
                    .HasColumnName("EXCHANGE");

                entity.Property(e => e.Include).HasColumnName("INCLUDE");

                entity.Property(e => e.IsEtf).HasColumnName("IS_ETF");

                entity.Property(e => e.LastfoundEod)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_EOD");

                entity.Property(e => e.LastfoundIqfeed)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_IQFEED");

                entity.Property(e => e.LastfoundPolygon)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_POLYGON");

                entity.Property(e => e.LastfoundTiingo)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_TIINGO");

                entity.Property(e => e.MissedEod).HasColumnName("MISSED_EOD");

                entity.Property(e => e.MissedIqfeed).HasColumnName("MISSED_IQFEED");

                entity.Property(e => e.MissedPolygon).HasColumnName("MISSED_POLYGON");

                entity.Property(e => e.MissedTiingo).HasColumnName("MISSED_TIINGO");

                entity.Property(e => e.ProcessedEod).HasColumnName("PROCESSED_EOD");

                entity.Property(e => e.ProcessedIqfeed).HasColumnName("PROCESSED_IQFEED");

                entity.Property(e => e.ProcessedPolygon).HasColumnName("PROCESSED_POLYGON");

                entity.Property(e => e.ProcessedTiingo).HasColumnName("PROCESSED_TIINGO");

                entity.Property(e => e.Securityname)
                    .HasMaxLength(250)
                    .HasColumnName("SECURITYNAME");

                entity.Property(e => e.StageId).HasColumnName("STAGE_ID");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<RawStockEod3yr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAW_STOCK_EOD_3YR", "STOCKODDS");

                entity.HasIndex(e => e.Date, "nci_wi_RAW_STOCK_EOD_3YR_5B6B227FC1B36103DC3CEF2C6B71CEA7");

                entity.Property(e => e.Close).HasColumnName("CLOSE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.ExtractedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("EXTRACTED_ON");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.Open).HasColumnName("OPEN");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<RawStockIqfeed3yr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAW_STOCK_IQFEED_3YR", "STOCKODDS");

                entity.HasIndex(e => e.Date, "nci_wi_RAW_STOCK_IQFEED_3YR_3507DECCC9A90ADC90CE87F98C2015E7");

                entity.Property(e => e.Close).HasColumnName("CLOSE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.ExtractedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EXTRACTED_ON");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.MasterSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Open).HasColumnName("OPEN");

                entity.Property(e => e.OpenInterest).HasColumnName("OPEN_INTEREST");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<RawStockPolygon3yr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAW_STOCK_POLYGON_3YR", "STOCKODDS");

                entity.HasIndex(e => e.Date, "nci_wi_RAW_STOCK_POLYGON_3YR_744E71B462F4710C5B549B357F7531AF");

                entity.Property(e => e.Adjusted).HasColumnName("ADJUSTED");

                entity.Property(e => e.Close).HasColumnName("CLOSE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.ExtractedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EXTRACTED_ON");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.MasterSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Open).HasColumnName("OPEN");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");

                entity.Property(e => e.Vwap).HasColumnName("VWAP");
            });

            modelBuilder.Entity<RawStockScoringTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAW_STOCK_SCORING_TABLE", "STAGE");

                entity.HasIndex(e => e.Date, "nci_wi_RAW_STOCK_SCORING_TABLE_NEW_01142BFBA514DB1F05C06EF4C012E5A2");

                entity.Property(e => e.ChngfromprevE).HasColumnName("CHNGFROMPREV_E");

                entity.Property(e => e.ChngfromprevI).HasColumnName("CHNGFROMPREV_I");

                entity.Property(e => e.ChngfromprevP).HasColumnName("CHNGFROMPREV_P");

                entity.Property(e => e.ChngfromprevRef).HasColumnName("CHNGFROMPREV_REF");

                entity.Property(e => e.ChngfromprevT).HasColumnName("CHNGFROMPREV_T");

                entity.Property(e => e.ChngprevE).HasColumnName("CHNGPREV_E");

                entity.Property(e => e.ChngprevI).HasColumnName("CHNGPREV_I");

                entity.Property(e => e.ChngprevP).HasColumnName("CHNGPREV_P");

                entity.Property(e => e.ChngprevT).HasColumnName("CHNGPREV_T");

                entity.Property(e => e.CloseE).HasColumnName("CLOSE_E");

                entity.Property(e => e.CloseI).HasColumnName("CLOSE_I");

                entity.Property(e => e.CloseP).HasColumnName("CLOSE_P");

                entity.Property(e => e.CloseT).HasColumnName("CLOSE_T");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Diff100E).HasColumnName("DIFF100_E");

                entity.Property(e => e.Diff100I).HasColumnName("DIFF100_I");

                entity.Property(e => e.Diff100P).HasColumnName("DIFF100_P");

                entity.Property(e => e.Diff100T).HasColumnName("DIFF100_T");

                entity.Property(e => e.DifffrommedE).HasColumnName("DIFFFROMMED_E");

                entity.Property(e => e.DifffrommedI).HasColumnName("DIFFFROMMED_I");

                entity.Property(e => e.DifffrommedP).HasColumnName("DIFFFROMMED_P");

                entity.Property(e => e.DifffrommedT).HasColumnName("DIFFFROMMED_T");

                entity.Property(e => e.Match1E).HasColumnName("MATCH1_E");

                entity.Property(e => e.Match1I).HasColumnName("MATCH1_I");

                entity.Property(e => e.Match1P).HasColumnName("MATCH1_P");

                entity.Property(e => e.Match1T).HasColumnName("MATCH1_T");

                entity.Property(e => e.Match2E).HasColumnName("MATCH2_E");

                entity.Property(e => e.Match2I).HasColumnName("MATCH2_I");

                entity.Property(e => e.Match2P).HasColumnName("MATCH2_P");

                entity.Property(e => e.Match2T).HasColumnName("MATCH2_T");

                entity.Property(e => e.Match3E).HasColumnName("MATCH3_E");

                entity.Property(e => e.Match3I).HasColumnName("MATCH3_I");

                entity.Property(e => e.Match3P).HasColumnName("MATCH3_P");

                entity.Property(e => e.Match3T).HasColumnName("MATCH3_T");

                entity.Property(e => e.Median).HasColumnName("MEDIAN");

                entity.Property(e => e.Minmaxrange).HasColumnName("MINMAXRANGE");

                entity.Property(e => e.Minmaxrangespread).HasColumnName("MINMAXRANGESPREAD");

                entity.Property(e => e.NomatchE).HasColumnName("NOMATCH_E");

                entity.Property(e => e.NomatchI).HasColumnName("NOMATCH_I");

                entity.Property(e => e.NomatchP).HasColumnName("NOMATCH_P");

                entity.Property(e => e.NomatchT).HasColumnName("NOMATCH_T");

                entity.Property(e => e.NovalueE).HasColumnName("NOVALUE_E");

                entity.Property(e => e.NovalueI).HasColumnName("NOVALUE_I");

                entity.Property(e => e.NovalueP).HasColumnName("NOVALUE_P");

                entity.Property(e => e.NovalueT).HasColumnName("NOVALUE_T");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.SymbolE)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_E");

                entity.Property(e => e.SymbolI)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_I");

                entity.Property(e => e.SymbolP)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_P");

                entity.Property(e => e.SymbolT)
                    .HasMaxLength(20)
                    .HasColumnName("SYMBOL_T");
            });

            modelBuilder.Entity<RawStockTiingo3yr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RAW_STOCK_TIINGO_3YR", "STOCKODDS");

                entity.HasIndex(e => e.Date, "nci_wi_RAW_STOCK_TIINGO_3YR_E5891BE487D0CB5F3A120571432B2917");

                entity.Property(e => e.AdjClose).HasColumnName("ADJ_CLOSE");

                entity.Property(e => e.AdjHigh).HasColumnName("ADJ_HIGH");

                entity.Property(e => e.AdjLow).HasColumnName("ADJ_LOW");

                entity.Property(e => e.AdjOpen).HasColumnName("ADJ_OPEN");

                entity.Property(e => e.AdjVolume).HasColumnName("ADJ_VOLUME");

                entity.Property(e => e.Close).HasColumnName("CLOSE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.DivCash).HasColumnName("DIV_CASH");

                entity.Property(e => e.ExtractedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EXTRACTED_ON");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.MasterSymbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Open).HasColumnName("OPEN");

                entity.Property(e => e.SplitFactor).HasColumnName("SPLIT_FACTOR");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Volume).HasColumnName("VOLUME");
            });

            modelBuilder.Entity<ReferenceMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REFERENCE_MAPPING", "STAGE");

                entity.Property(e => e.CorrCoeff).HasColumnName("CORR_COEFF");

                entity.Property(e => e.Effectivefromdate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEFROMDATE");

                entity.Property(e => e.ReferenceEtf)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCE_ETF");

                entity.Property(e => e.StageId).HasColumnName("STAGE_ID");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<ReferenceMappingOld0612>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REFERENCE_MAPPING_OLD_0612", "STAGE");

                entity.Property(e => e.CorrCoeff).HasColumnName("CORR_COEFF");

                entity.Property(e => e.Effectivefromdate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEFROMDATE");

                entity.Property(e => e.ReferenceEtf)
                    .IsUnicode(false)
                    .HasColumnName("REFERENCE_ETF");

                entity.Property(e => e.StageId).HasColumnName("STAGE_ID");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<ReferenceSecurity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REFERENCE_SECURITIES", "STOCKODDS");

                entity.Property(e => e.CorrCoeff).HasColumnName("CORR_COEFF");

                entity.Property(e => e.IsEtf).HasColumnName("IS_ETF");

                entity.Property(e => e.Symbol1)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL1");

                entity.Property(e => e.Symbol2)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL2");
            });

            modelBuilder.Entity<StocksAddedRenamed20200819>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_ADDED_RENAMED_2020_08_19", "STAGE");

                entity.Property(e => e.NewSymbol)
                    .HasMaxLength(10)
                    .HasColumnName("NEW_SYMBOL");

                entity.Property(e => e.OldSymbol)
                    .HasMaxLength(10)
                    .HasColumnName("OLD_SYMBOL");
            });

            modelBuilder.Entity<StocksAddedRenamed20200903>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_ADDED_RENAMED_2020_09_03", "STAGE");

                entity.Property(e => e.NewSymbol)
                    .HasMaxLength(10)
                    .HasColumnName("NEW_SYMBOL");

                entity.Property(e => e.OldSymbol)
                    .HasMaxLength(10)
                    .HasColumnName("OLD_SYMBOL");
            });

            modelBuilder.Entity<StocksRemoved20200727>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_REMOVED_2020_07_27", "STAGE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<StocksRemoved20200819>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_REMOVED_2020_08_19", "STAGE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<StocksRemoved20200903>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_REMOVED_2020_09_03", "STAGE");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<StocksRemovedMeeting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_REMOVED_MEETINGS", "STAGE");

                entity.Property(e => e.CurrentflagChangeDate)
                    .HasColumnType("date")
                    .HasColumnName("CURRENTFLAG_CHANGE_DATE");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<StocksRemovedStoredProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_REMOVED_STORED_PROC", "STAGE");

                entity.Property(e => e.CurrentflagChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CURRENTFLAG_CHANGE_DATE");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<StocksRenamedStoredProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCKS_RENAMED_STORED_PROC", "STAGE");

                entity.Property(e => e.NewSymbolName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NEW_SYMBOL_NAME");

                entity.Property(e => e.OldSymbolName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("OLD_SYMBOL_NAME");

                entity.Property(e => e.SymbolChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SYMBOL_CHANGE_DATE");
            });

            modelBuilder.Entity<SymbolListEod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYMBOL_LIST_EOD", "PRESTAGE");

                entity.HasIndex(e => e.Index, "ix_PRESTAGE_SYMBOL_LIST_EOD_index");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.LastfoundEod)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_EOD");

                entity.Property(e => e.Merge)
                    .IsUnicode(false)
                    .HasColumnName("MERGE");

                entity.Property(e => e.MissedEod).HasColumnName("MISSED_EOD");

                entity.Property(e => e.ProcessedEod).HasColumnName("PROCESSED_EOD");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<SymbolListIqfeed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYMBOL_LIST_IQFEED", "PRESTAGE");

                entity.HasIndex(e => e.Index, "ix_PRESTAGE_SYMBOL_LIST_IQFEED_index");

                entity.Property(e => e.Date)
                    .IsUnicode(false)
                    .HasColumnName("DATE");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.IqfeedSymbols)
                    .IsUnicode(false)
                    .HasColumnName("IQFeed_Symbols");

                entity.Property(e => e.LastfoundIqfeed)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_IQFEED");

                entity.Property(e => e.MasterSymbol)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Merge)
                    .IsUnicode(false)
                    .HasColumnName("MERGE");

                entity.Property(e => e.MissedIqfeed).HasColumnName("MISSED_IQFEED");

                entity.Property(e => e.ProcessedIqfeed).HasColumnName("PROCESSED_IQFEED");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<SymbolListPolygon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYMBOL_LIST_POLYGON", "PRESTAGE");

                entity.HasIndex(e => e.Index, "ix_PRESTAGE_SYMBOL_LIST_POLYGON_index");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.LastfoundPolygon)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_POLYGON");

                entity.Property(e => e.MasterSymbol)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Merge)
                    .IsUnicode(false)
                    .HasColumnName("MERGE");

                entity.Property(e => e.MissedPolygon).HasColumnName("MISSED_POLYGON");

                entity.Property(e => e.PolygonSymbols)
                    .IsUnicode(false)
                    .HasColumnName("Polygon_Symbols");

                entity.Property(e => e.ProcessedPolygon).HasColumnName("PROCESSED_POLYGON");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<SymbolListTiingo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYMBOL_LIST_TIINGO", "PRESTAGE");

                entity.HasIndex(e => e.Index, "ix_PRESTAGE_SYMBOL_LIST_TIINGO_index");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.LastfoundTiingo)
                    .HasColumnType("date")
                    .HasColumnName("LASTFOUND_TIINGO");

                entity.Property(e => e.MasterSymbol)
                    .IsUnicode(false)
                    .HasColumnName("MASTER_SYMBOL");

                entity.Property(e => e.Merge)
                    .IsUnicode(false)
                    .HasColumnName("MERGE");

                entity.Property(e => e.MissedTiingo).HasColumnName("MISSED_TIINGO");

                entity.Property(e => e.ProcessedTiingo).HasColumnName("PROCESSED_TIINGO");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.TiingoSymbols)
                    .IsUnicode(false)
                    .HasColumnName("Tiingo_Symbols");
            });

            modelBuilder.Entity<UpdateChngfromprevRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPDATE_CHNGFROMPREV_REF", "PRESTAGE");

                entity.Property(e => e.ChngfromprevE).HasColumnName("CHNGFROMPREV_E");

                entity.Property(e => e.ChngfromprevI).HasColumnName("CHNGFROMPREV_I");

                entity.Property(e => e.ChngfromprevP).HasColumnName("CHNGFROMPREV_P");

                entity.Property(e => e.ChngfromprevRef).HasColumnName("CHNGFROMPREV_REF");

                entity.Property(e => e.ChngfromprevT).HasColumnName("CHNGFROMPREV_T");

                entity.Property(e => e.CloseE).HasColumnName("CLOSE_E");

                entity.Property(e => e.CloseI).HasColumnName("CLOSE_I");

                entity.Property(e => e.CloseP).HasColumnName("CLOSE_P");

                entity.Property(e => e.CloseT).HasColumnName("CLOSE_T");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Symbol)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.SymbolE)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL_E");

                entity.Property(e => e.SymbolI)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL_I");

                entity.Property(e => e.SymbolP)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL_P");

                entity.Property(e => e.SymbolT)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL_T");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
