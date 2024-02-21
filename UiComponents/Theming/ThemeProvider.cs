using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace UiComponents.Theming;

public abstract class Theming
{
    public static class Icons
    {
        public const string AcademicCap = "academic-cap";
        public const string AdjustmentsHorizontal = "adjustments-horizontal";
        public const string AdjustmentsVertical = "adjustments-vertical";
        public const string ArchiveBoxArrowDown = "archive-box-arrow-down";
        public const string ArchiveBoxXMark = "archive-box-x-mark";
        public const string ArchiveBox = "archive-box";
        public const string ArrowDownCircle = "arrow-down-circle";
        public const string ArrowDownLeft = "arrow-down-left";
        public const string ArrowDownOnSquareStack = "arrow-down-on-square-stack";
        public const string ArrowDownOnSquare = "arrow-down-on-square";
        public const string ArrowDownRight = "arrow-down-right";
        public const string ArrowDownTray = "arrow-down-tray";
        public const string ArrowDown = "arrow-down";
        public const string ArrowLeftCircle = "arrow-left-circle";
        public const string ArrowLeftEndOnRectangle = "arrow-left-end-on-rectangle";
        public const string ArrowLeftOnRectangle = "arrow-left-on-rectangle";
        public const string ArrowLeftStartOnRectangle = "arrow-left-start-on-rectangle";
        public const string ArrowLeft = "arrow-left";
        public const string ArrowLongDown = "arrow-long-down";
        public const string ArrowLongLeft = "arrow-long-left";
        public const string ArrowLongRight = "arrow-long-right";
        public const string ArrowLongUp = "arrow-long-up";
        public const string ArrowPathRoundedSquare = "arrow-path-rounded-square";
        public const string ArrowPath = "arrow-path";
        public const string ArrowRightCircle = "arrow-right-circle";
        public const string ArrowRightEndOnRectangle = "arrow-right-end-on-rectangle";
        public const string ArrowRightOnRectangle = "arrow-right-on-rectangle";
        public const string ArrowRightStartOnRectangle = "arrow-right-start-on-rectangle";
        public const string ArrowRight = "arrow-right";
        public const string ArrowSmallDown = "arrow-small-down";
        public const string ArrowSmallLeft = "arrow-small-left";
        public const string ArrowSmallRight = "arrow-small-right";
        public const string ArrowSmallUp = "arrow-small-up";
        public const string ArrowTopRightOnSquare = "arrow-top-right-on-square";
        public const string ArrowTrendingDown = "arrow-trending-down";
        public const string ArrowTrendingUp = "arrow-trending-up";
        public const string ArrowUpCircle = "arrow-up-circle";
        public const string ArrowUpLeft = "arrow-up-left";
        public const string ArrowUpOnSquareStack = "arrow-up-on-square-stack";
        public const string ArrowUpOnSquare = "arrow-up-on-square";
        public const string ArrowUpRight = "arrow-up-right";
        public const string ArrowUpTray = "arrow-up-tray";
        public const string ArrowUp = "arrow-up";
        public const string ArrowUTurnDown = "arrow-uturn-down";
        public const string ArrowUTurnLeft = "arrow-uturn-left";
        public const string ArrowUTurnRight = "arrow-uturn-right";
        public const string ArrowUTurnUp = "arrow-uturn-up";
        public const string ArrowsPointingIn = "arrows-pointing-in";
        public const string ArrowsPointingOut = "arrows-pointing-out";
        public const string ArrowsRightLeft = "arrows-right-left";
        public const string ArrowsUpDown = "arrows-up-down";
        public const string AtSymbol = "at-symbol";
        public const string Backspace = "backspace";
        public const string Backward = "backward";
        public const string Banknotes = "banknotes";
        public const string Bars2 = "bars-2";
        public const string Bars3BottomLeft = "bars-3-bottom-left";
        public const string Bars3BottomRight = "bars-3-bottom-right";
        public const string Bars3CenterLeft = "bars-3-center-left";
        public const string Bars3 = "bars-3";
        public const string Bars4 = "bars-4";
        public const string BarsArrowDown = "bars-arrow-down";
        public const string BarsArrowUp = "bars-arrow-up";
        public const string Battery0 = "battery-0";
        public const string Battery100 = "battery-100";
        public const string Battery50 = "battery-50";
        public const string Beaker = "beaker";
        public const string BellAlert = "bell-alert";
        public const string BellSlash = "bell-slash";
        public const string BellSnooze = "bell-snooze";
        public const string Bell = "bell";
        public const string BoltSlash = "bolt-slash";
        public const string Bolt = "bolt";
        public const string BookOpen = "book-open";
        public const string BookmarkSlash = "bookmark-slash";
        public const string BookmarkSquare = "bookmark-square";
        public const string Bookmark = "bookmark";
        public const string Briefcase = "briefcase";
        public const string BugAnt = "bug-ant";
        public const string BuildingLibrary = "building-library";
        public const string BuildingOffice2 = "building-office-2";
        public const string BuildingOffice = "building-office";
        public const string BuildingStorefront = "building-storefront";
        public const string Cake = "cake";
        public const string Calculator = "calculator";
        public const string CalendarDays = "calendar-days";
        public const string Calendar = "calendar";
        public const string Camera = "camera";
        public const string ChartBarSquare = "chart-bar-square";
        public const string ChartBar = "chart-bar";
        public const string ChartPie = "chart-pie";
        public const string ChatBubbleBottomCenterText = "chat-bubble-bottom-center-text";
        public const string ChatBubbleBottomCenter = "chat-bubble-bottom-center";
        public const string ChatBubbleLeftEllipsis = "chat-bubble-left-ellipsis";
        public const string ChatBubbleLeftRight = "chat-bubble-left-right";
        public const string ChatBubbleLeft = "chat-bubble-left";
        public const string ChatBubbleOvalLeftEllipsis = "chat-bubble-oval-left-ellipsis";
        public const string ChatBubbleOvalLeft = "chat-bubble-oval-left";
        public const string CheckBadge = "check-badge";
        public const string CheckCircle = "check-circle";
        public const string Check = "check";
        public const string ChevronDoubleDown = "chevron-double-down";
        public const string ChevronDoubleLeft = "chevron-double-left";
        public const string ChevronDoubleRight = "chevron-double-right";
        public const string ChevronDoubleUp = "chevron-double-up";
        public const string ChevronDown = "chevron-down";
        public const string ChevronLeft = "chevron-left";
        public const string ChevronRight = "chevron-right";
        public const string ChevronUpDown = "chevron-up-down";
        public const string ChevronUp = "chevron-up";
        public const string CircleStack = "circle-stack";
        public const string ClipboardDocumentCheck = "clipboard-document-check";
        public const string ClipboardDocumentList = "clipboard-document-list";
        public const string ClipboardDocument = "clipboard-document";
        public const string Clipboard = "clipboard";
        public const string Clock = "clock";
        public const string CloudArrowDown = "cloud-arrow-down";
        public const string CloudArrowUp = "cloud-arrow-up";
        public const string Cloud = "cloud";
        public const string CodeBracketSquare = "code-bracket-square";
        public const string CodeBracket = "code-bracket";
        public const string Cog6Tooth = "cog-6-tooth";
        public const string Cog8Tooth = "cog-8-tooth";
        public const string Cog = "cog";
        public const string CommandLine = "command-line";
        public const string ComputerDesktop = "computer-desktop";
        public const string CpuChip = "cpu-chip";
        public const string CreditCard = "credit-card";
        public const string CubeTransparent = "cube-transparent";
        public const string Cube = "cube";
        public const string CurrencyBangladeshi = "currency-bangladeshi";
        public const string CurrencyDollar = "currency-dollar";
        public const string CurrencyEuro = "currency-euro";
        public const string CurrencyPound = "currency-pound";
        public const string CurrencyRupee = "currency-rupee";
        public const string CurrencyYen = "currency-yen";
        public const string CursorArrowRays = "cursor-arrow-rays";
        public const string CursorArrowRipple = "cursor-arrow-ripple";
        public const string DevicePhoneMobile = "device-phone-mobile";
        public const string DeviceTablet = "device-tablet";
        public const string DocumentArrowDown = "document-arrow-down";
        public const string DocumentArrowUp = "document-arrow-up";
        public const string DocumentChartBar = "document-chart-bar";
        public const string DocumentCheck = "document-check";
        public const string DocumentDuplicate = "document-duplicate";
        public const string DocumentMagnifyingGlass = "document-magnifying-glass";
        public const string DocumentMinus = "document-minus";
        public const string DocumentPlus = "document-plus";
        public const string DocumentText = "document-text";
        public const string Document = "document";
        public const string EllipsisHorizontalCircle = "ellipsis-horizontal-circle";
        public const string EllipsisHorizontal = "ellipsis-horizontal";
        public const string EllipsisVertical = "ellipsis-vertical";
        public const string EnvelopeOpen = "envelope-open";
        public const string Envelope = "envelope";
        public const string ExclamationCircle = "exclamation-circle";
        public const string ExclamationTriangle = "exclamation-triangle";
        public const string EyeDropper = "eye-dropper";
        public const string EyeSlash = "eye-slash";
        public const string Eye = "eye";
        public const string FaceFrown = "face-frown";
        public const string FaceSmile = "face-smile";
        public const string Film = "film";
        public const string FingerPrint = "finger-print";
        public const string Fire = "fire";
        public const string Flag = "flag";
        public const string FolderArrowDown = "folder-arrow-down";
        public const string FolderMinus = "folder-minus";
        public const string FolderOpen = "folder-open";
        public const string FolderPlus = "folder-plus";
        public const string Folder = "folder";
        public const string Forward = "forward";
        public const string Funnel = "funnel";
        public const string Gif = "gif";
        public const string GiftTop = "gift-top";
        public const string Gift = "gift";
        public const string GlobeAlt = "globe-alt";
        public const string GlobeAmericas = "globe-americas";
        public const string GlobeAsiaAustralia = "globe-asia-australia";
        public const string GlobeEuropeAfrica = "globe-europe-africa";
        public const string HandRaised = "hand-raised";
        public const string HandThumbDown = "hand-thumb-down";
        public const string HandThumbUp = "hand-thumb-up";
        public const string Hashtag = "hashtag";
        public const string Heart = "heart";
        public const string HomeModern = "home-modern";
        public const string Home = "home";
        public const string Identification = "identification";
        public const string InboxArrowDown = "inbox-arrow-down";
        public const string InboxStack = "inbox-stack";
        public const string Inbox = "inbox";
        public const string InformationCircle = "information-circle";
        public const string Key = "key";
        public const string Language = "language";
        public const string Lifebuoy = "lifebuoy";
        public const string LightBulb = "light-bulb";
        public const string Link = "link";
        public const string ListBullet = "list-bullet";
        public const string LockClosed = "lock-closed";
        public const string LockOpen = "lock-open";
        public const string MagnifyingGlassCircle = "magnifying-glass-circle";
        public const string MagnifyingGlassMinus = "magnifying-glass-minus";
        public const string MagnifyingGlassPlus = "magnifying-glass-plus";
        public const string MagnifyingGlass = "magnifying-glass";
        public const string MapPin = "map-pin";
        public const string Map = "map";
        public const string Megaphone = "megaphone";
        public const string Microphone = "microphone";
        public const string MinusCircle = "minus-circle";
        public const string MinusSmall = "minus-small";
        public const string Minus = "minus";
        public const string Moon = "moon";
        public const string MusicalNote = "musical-note";
        public const string Newspaper = "newspaper";
        public const string NoSymbol = "no-symbol";
        public const string PaintBrush = "paint-brush";
        public const string PaperAirplane = "paper-airplane";
        public const string PaperClip = "paper-clip";
        public const string PauseCircle = "pause-circle";
        public const string Pause = "pause";
        public const string PencilSquare = "pencil-square";
        public const string Pencil = "pencil";
        public const string PhoneArrowDownLeft = "phone-arrow-down-left";
        public const string PhoneArrowUpRight = "phone-arrow-up-right";
        public const string PhoneXMark = "phone-x-mark";
        public const string Phone = "phone";
        public const string Photo = "photo";
        public const string PlayCircle = "play-circle";
        public const string PlayPause = "play-pause";
        public const string Play = "play";
        public const string PlusCircle = "plus-circle";
        public const string PlusSmall = "plus-small";
        public const string Plus = "plus";
        public const string Power = "power";
        public const string PresentationChartBar = "presentation-chart-bar";
        public const string PresentationChartLine = "presentation-chart-line";
        public const string Printer = "printer";
        public const string PuzzlePiece = "puzzle-piece";
        public const string QrCode = "qr-code";
        public const string QuestionMarkCircle = "question-mark-circle";
        public const string QueueList = "queue-list";
        public const string Radio = "radio";
        public const string ReceiptPercent = "receipt-percent";
        public const string ReceiptRefund = "receipt-refund";
        public const string RectangleGroup = "rectangle-group";
        public const string RectangleStack = "rectangle-stack";
        public const string RocketLaunch = "rocket-launch";
        public const string Rss = "rss";
        public const string Scale = "scale";
        public const string Scissors = "scissors";
        public const string ServerStack = "server-stack";
        public const string Server = "server";
        public const string Share = "share";
        public const string ShieldCheck = "shield-check";
        public const string ShieldExclamation = "shield-exclamation";
        public const string ShoppingBag = "shopping-bag";
        public const string ShoppingCart = "shopping-cart";
        public const string SignalSlash = "signal-slash";
        public const string Signal = "signal";
        public const string Sparkles = "sparkles";
        public const string SpeakerWave = "speaker-wave";
        public const string SpeakerXMark = "speaker-x-mark";
        public const string Square2Stack = "square-2-stack";
        public const string Square3Stack3D = "square-3-stack-3d";
        public const string Squares2X2 = "squares-2x2";
        public const string SquaresPlus = "squares-plus";
        public const string Star = "star";
        public const string StopCircle = "stop-circle";
        public const string Stop = "stop";
        public const string Sun = "sun";
        public const string Swatch = "swatch";
        public const string TableCells = "table-cells";
        public const string Tag = "tag";
        public const string Ticket = "ticket";
        public const string Trash = "trash";
        public const string Trophy = "trophy";
        public const string Truck = "truck";
        public const string Tv = "tv";
        public const string UserCircle = "user-circle";
        public const string UserGroup = "user-group";
        public const string UserMinus = "user-minus";
        public const string UserPlus = "user-plus";
        public const string User = "user";
        public const string Users = "users";
        public const string Variable = "variable";
        public const string VideoCameraSlash = "video-camera-slash";
        public const string VideoCamera = "video-camera";
        public const string ViewColumns = "view-columns";
        public const string ViewfinderCircle = "viewfinder-circle";
        public const string Wallet = "wallet";
        public const string Wifi = "wifi";
        public const string Window = "window";
        public const string WrenchScrewdriver = "wrench-screwdriver";
        public const string Wrench = "wrench";
        public const string XCircle = "x-circle";
        public const string XMark = "x-mark";
    };

    public static class Layout
    {
        public const string App = nameof(ThemeProvider.App);
        public const string Drawer = nameof(ThemeProvider.Drawer);
        public const string Body = nameof(ThemeProvider.Body);
    }

    public static class Colors
    {
        public const string BgDefault = nameof(ThemeProvider.BgColorDefault);
        public const string FgDefault = nameof(ThemeProvider.FgColorDefault);
        public const string BgEmphasis = nameof(ThemeProvider.BgColorEmphasis);
        public const string FgEmphasis = nameof(ThemeProvider.FgColorEmphasis);
        public const string BgSubtle = nameof(ThemeProvider.BgColorSubtle);
        public const string FgSubtle = nameof(ThemeProvider.FgColorSubtle);
        public const string BgInset = nameof(ThemeProvider.BgColorInset);
        public const string FgInset = nameof(ThemeProvider.FgColorInset);
    }

    public static class IconStyles
    {
        public const string Outline = nameof(Outline);
        public const string Solid = nameof(Solid);
    }

    public static class ButtonStyles
    {
        public const string Base = nameof(ThemeProvider.BaseButton);
        public const string Primary = nameof(ThemeProvider.PrimaryButton);
        public const string Secondary = nameof(ThemeProvider.SecondaryButton);
        public const string Danger = nameof(ThemeProvider.DangerButton);
        public const string Invisible = nameof(ThemeProvider.InvisibleButton);
        public const string Icon = nameof(ThemeProvider.IconButton);
    }

    public static class Effects
    {
        public const string Ripple = nameof(ThemeProvider.RippleEffect);
        public const string Focus = nameof(ThemeProvider.FocusEffect);
    }
}

public class ThemeProvider : IDisposable
{
    private readonly PersistentComponentState _state;
    private readonly PersistingComponentStateSubscription _subscription;

    public ThemeProvider(PersistentComponentState state)
    {
        _state = state;
        _subscription = _state.RegisterOnPersisting(OnPersisting, new InteractiveAutoRenderMode());

        BgColorDefault = FindInState(nameof(BgColorDefault), BgColorDefault);
        FgColorDefault = FindInState(nameof(FgColorDefault), FgColorDefault);
        BgColorEmphasis = FindInState(nameof(BgColorEmphasis), BgColorEmphasis);
        FgColorEmphasis = FindInState(nameof(FgColorEmphasis), FgColorEmphasis);
        BgColorSubtle = FindInState(nameof(BgColorSubtle), BgColorSubtle);
        FgColorSubtle = FindInState(nameof(FgColorSubtle), FgColorSubtle);
        BgColorInset = FindInState(nameof(BgColorInset), BgColorInset);
        FgColorInset = FindInState(nameof(FgColorInset), FgColorInset);
        BaseButton = FindInState(nameof(BaseButton), BaseButton);
        PrimaryButton = FindInState(nameof(PrimaryButton), PrimaryButton);
        SecondaryButton = FindInState(nameof(SecondaryButton), SecondaryButton);
        DangerButton = FindInState(nameof(DangerButton), DangerButton);
        InvisibleButton = FindInState(nameof(InvisibleButton), InvisibleButton);
        IconButton = FindInState(nameof(IconButton), IconButton);
        IconOutline = FindInState(nameof(IconOutline), IconOutline);
        IconSolid = FindInState(nameof(IconSolid), IconSolid);
        RippleEffect = FindInState(nameof(RippleEffect), RippleEffect);
        FocusEffect = FindInState(nameof(FocusEffect), FocusEffect);
        App = FindInState(nameof(App), App);
        Drawer = FindInState(nameof(Drawer), Drawer);
        Body = FindInState(nameof(Body), Body);
    }

    public string? BgColorDefault { get; init; }
    public string? FgColorDefault { get; init; }
    public string? BgColorEmphasis { get; init; }
    public string? FgColorEmphasis { get; init; }
    public string? BgColorSubtle { get; init; }
    public string? FgColorSubtle { get; init; }
    public string? BgColorInset { get; init; }
    public string? FgColorInset { get; init; }
    public string? BaseButton { get; init; }
    public string? PrimaryButton { get; init; }
    public string? SecondaryButton { get; init; }
    public string? DangerButton { get; init; }
    public string? InvisibleButton { get; init; }
    public string? IconButton { get; init; }
    public string? IconOutline { get; init; }
    public string? IconSolid { get; init; }
    public string? RippleEffect { get; init; }
    public string? FocusEffect { get; init; }
    public string? App { get; init; }
    public string? Drawer { get; init; }
    public string? Body { get; init; }

    public void Dispose()
    {
        _subscription.Dispose();
        GC.SuppressFinalize(this);
    }

    private Task OnPersisting()
    {
        _state.PersistAsJson(nameof(BgColorDefault), BgColorDefault);
        _state.PersistAsJson(nameof(FgColorDefault), FgColorDefault);
        _state.PersistAsJson(nameof(BgColorEmphasis), BgColorEmphasis);
        _state.PersistAsJson(nameof(FgColorEmphasis), FgColorEmphasis);
        _state.PersistAsJson(nameof(BgColorSubtle), BgColorSubtle);
        _state.PersistAsJson(nameof(FgColorSubtle), FgColorSubtle);
        _state.PersistAsJson(nameof(BgColorInset), BgColorInset);
        _state.PersistAsJson(nameof(FgColorInset), FgColorInset);
        _state.PersistAsJson(nameof(BaseButton), BaseButton);
        _state.PersistAsJson(nameof(PrimaryButton), PrimaryButton);
        _state.PersistAsJson(nameof(SecondaryButton), SecondaryButton);
        _state.PersistAsJson(nameof(DangerButton), DangerButton);
        _state.PersistAsJson(nameof(InvisibleButton), InvisibleButton);
        _state.PersistAsJson(nameof(IconButton), IconButton);
        _state.PersistAsJson(nameof(IconOutline), IconOutline);
        _state.PersistAsJson(nameof(IconSolid), IconSolid);
        _state.PersistAsJson(nameof(RippleEffect), RippleEffect);
        _state.PersistAsJson(nameof(FocusEffect), FocusEffect);
        _state.PersistAsJson(nameof(App), App);
        _state.PersistAsJson(nameof(Drawer), Drawer);
        _state.PersistAsJson(nameof(Body), Body);

        return Task.CompletedTask;
    }

    private string? FindInState(string key, string? value)
    {
        var found = _state.TryTakeFromJson<string>(key, out var foundValue);
        return found ? foundValue : value;
    }
}