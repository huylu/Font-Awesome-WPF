
namespace FontAwesome.WPF {
	using System.ComponentModel;
	///<summary>
	///	FontAwesome v4.2.0 by Dave Gandy (@davegandy)
	///	The iconic font and CSS toolkit
	///	License http://fontawesome.io/license (Font: v4.2.0, C#: MIT License)
	///</summary>
	///<see cref="http://fontawesome.io" />
	///<seealso cref="https://github.com/FortAwesome/Font-Awesome" />
	///<seealso cref="https://github.com/charri/Font-Awesome-WPF" />
	public enum FontAwesomeIcon {
		None = 0x0,
		///<summary>Glass (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/glass/" />
		[IconCategory("Web Application Icons")]
		[Description("Glass")]
		Glass = 0xf000,
		///<summary>Music (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/music/" />
		[IconCategory("Web Application Icons")]
		[Description("Music")]
		Music = 0xf001,
		///<summary>Search (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/search/" />
		[IconCategory("Web Application Icons")]
		[Description("Search")]
		Search = 0xf002,
		///<summary>Envelope Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/envelope-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Envelope Outlined")]
		EnvelopeOutlined = 0xf003,
		///<summary>Heart (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/heart/" />
		[IconCategory("Web Application Icons")]
		[Description("Heart")]
		Heart = 0xf004,
		///<summary>Star (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/star/" />
		[IconCategory("Web Application Icons")]
		[Description("Star")]
		Star = 0xf005,
		///<summary>Star Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/star-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Star Outlined")]
		StarOutlined = 0xf006,
		///<summary>User (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/user/" />
		[IconCategory("Web Application Icons")]
		[Description("User")]
		User = 0xf007,
		///<summary>Film (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/film/" />
		[IconCategory("Web Application Icons")]
		[Description("Film")]
		Film = 0xf008,
		///<summary>th-large (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/th-large/" />
		[IconCategory("Text Editor Icons")]
		[Description("th-large")]
		ThLarge = 0xf009,
		///<summary>th (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/th/" />
		[IconCategory("Text Editor Icons")]
		[Description("th")]
		Th = 0xf00a,
		///<summary>th-list (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/th-list/" />
		[IconCategory("Text Editor Icons")]
		[Description("th-list")]
		ThList = 0xf00b,
		///<summary>Check (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/check/" />
		[IconCategory("Web Application Icons")]
		[Description("Check")]
		Check = 0xf00c,
		///<summary>Times (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/times/" />
		[IconCategory("Web Application Icons")]
		[Description("Times")]
		Times = 0xf00d,
		///<summary>Alias of: Times</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Times" />
		[IconAlias]
		Remove = Times,
		///<summary>Alias of: Times</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Times" />
		[IconAlias]
		Close = Times,
		///<summary>Search Plus (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/search-plus/" />
		[IconCategory("Web Application Icons")]
		[Description("Search Plus")]
		SearchPlus = 0xf00e,
		///<summary>Search Minus (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/search-minus/" />
		[IconCategory("Web Application Icons")]
		[Description("Search Minus")]
		SearchMinus = 0xf010,
		///<summary>Power Off (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/power-off/" />
		[IconCategory("Web Application Icons")]
		[Description("Power Off")]
		PowerOff = 0xf011,
		///<summary>signal (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/signal/" />
		[IconCategory("Web Application Icons")]
		[Description("signal")]
		Signal = 0xf012,
		///<summary>cog (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/cog/" />
		[IconCategory("Web Application Icons"),IconCategory("Spinner Icons")]
		[Description("cog")]
		Cog = 0xf013,
		///<summary>Alias of: Cog</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Cog" />
		[IconAlias]
		Gear = Cog,
		///<summary>Trash Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/trash-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Trash Outlined")]
		TrashOutlined = 0xf014,
		///<summary>home (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/home/" />
		[IconCategory("Web Application Icons")]
		[Description("home")]
		Home = 0xf015,
		///<summary>File Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/file-o/" />
		[IconCategory("Text Editor Icons"),IconCategory("File Type Icons")]
		[Description("File Outlined")]
		FileOutlined = 0xf016,
		///<summary>Clock Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/clock-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Clock Outlined")]
		ClockOutlined = 0xf017,
		///<summary>road (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/road/" />
		[IconCategory("Web Application Icons")]
		[Description("road")]
		Road = 0xf018,
		///<summary>Download (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/download/" />
		[IconCategory("Web Application Icons")]
		[Description("Download")]
		Download = 0xf019,
		///<summary>Arrow Circle Outlined Down (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-o-down/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Outlined Down")]
		ArrowCircleOutlinedDown = 0xf01a,
		///<summary>Arrow Circle Outlined Up (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-o-up/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Outlined Up")]
		ArrowCircleOutlinedUp = 0xf01b,
		///<summary>inbox (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/inbox/" />
		[IconCategory("Web Application Icons")]
		[Description("inbox")]
		Inbox = 0xf01c,
		///<summary>Play Circle Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/play-circle-o/" />
		[IconCategory("Video Player Icons")]
		[Description("Play Circle Outlined")]
		PlayCircleOutlined = 0xf01d,
		///<summary>Repeat (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/repeat/" />
		[IconCategory("Text Editor Icons")]
		[Description("Repeat")]
		Repeat = 0xf01e,
		///<summary>Alias of: Repeat</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Repeat" />
		[IconAlias]
		RotateRight = Repeat,
		///<summary>refresh (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/refresh/" />
		[IconCategory("Web Application Icons"),IconCategory("Spinner Icons")]
		[Description("refresh")]
		Refresh = 0xf021,
		///<summary>list-alt (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/list-alt/" />
		[IconCategory("Text Editor Icons")]
		[Description("list-alt")]
		ListAlt = 0xf022,
		///<summary>lock (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/lock/" />
		[IconCategory("Web Application Icons")]
		[Description("lock")]
		Lock = 0xf023,
		///<summary>flag (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/flag/" />
		[IconCategory("Web Application Icons")]
		[Description("flag")]
		Flag = 0xf024,
		///<summary>headphones (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/headphones/" />
		[IconCategory("Web Application Icons")]
		[Description("headphones")]
		Headphones = 0xf025,
		///<summary>volume-off (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/volume-off/" />
		[IconCategory("Web Application Icons")]
		[Description("volume-off")]
		VolumeOff = 0xf026,
		///<summary>volume-down (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/volume-down/" />
		[IconCategory("Web Application Icons")]
		[Description("volume-down")]
		VolumeDown = 0xf027,
		///<summary>volume-up (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/volume-up/" />
		[IconCategory("Web Application Icons")]
		[Description("volume-up")]
		VolumeUp = 0xf028,
		///<summary>qrcode (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/qrcode/" />
		[IconCategory("Web Application Icons")]
		[Description("qrcode")]
		Qrcode = 0xf029,
		///<summary>barcode (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/barcode/" />
		[IconCategory("Web Application Icons")]
		[Description("barcode")]
		Barcode = 0xf02a,
		///<summary>tag (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/tag/" />
		[IconCategory("Web Application Icons")]
		[Description("tag")]
		Tag = 0xf02b,
		///<summary>tags (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/tags/" />
		[IconCategory("Web Application Icons")]
		[Description("tags")]
		Tags = 0xf02c,
		///<summary>book (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/book/" />
		[IconCategory("Web Application Icons")]
		[Description("book")]
		Book = 0xf02d,
		///<summary>bookmark (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/bookmark/" />
		[IconCategory("Web Application Icons")]
		[Description("bookmark")]
		Bookmark = 0xf02e,
		///<summary>print (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/print/" />
		[IconCategory("Web Application Icons")]
		[Description("print")]
		Print = 0xf02f,
		///<summary>camera (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/camera/" />
		[IconCategory("Web Application Icons")]
		[Description("camera")]
		Camera = 0xf030,
		///<summary>font (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/font/" />
		[IconCategory("Text Editor Icons")]
		[Description("font")]
		Font = 0xf031,
		///<summary>bold (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/bold/" />
		[IconCategory("Text Editor Icons")]
		[Description("bold")]
		Bold = 0xf032,
		///<summary>italic (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/italic/" />
		[IconCategory("Text Editor Icons")]
		[Description("italic")]
		Italic = 0xf033,
		///<summary>text-height (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/text-height/" />
		[IconCategory("Text Editor Icons")]
		[Description("text-height")]
		TextHeight = 0xf034,
		///<summary>text-width (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/text-width/" />
		[IconCategory("Text Editor Icons")]
		[Description("text-width")]
		TextWidth = 0xf035,
		///<summary>align-left (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/align-left/" />
		[IconCategory("Text Editor Icons")]
		[Description("align-left")]
		AlignLeft = 0xf036,
		///<summary>align-center (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/align-center/" />
		[IconCategory("Text Editor Icons")]
		[Description("align-center")]
		AlignCenter = 0xf037,
		///<summary>align-right (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/align-right/" />
		[IconCategory("Text Editor Icons")]
		[Description("align-right")]
		AlignRight = 0xf038,
		///<summary>align-justify (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/align-justify/" />
		[IconCategory("Text Editor Icons")]
		[Description("align-justify")]
		AlignJustify = 0xf039,
		///<summary>list (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/list/" />
		[IconCategory("Text Editor Icons")]
		[Description("list")]
		List = 0xf03a,
		///<summary>Outdent (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/outdent/" />
		[IconCategory("Text Editor Icons")]
		[Description("Outdent")]
		Outdent = 0xf03b,
		///<summary>Alias of: Outdent</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Outdent" />
		[IconAlias]
		Dedent = Outdent,
		///<summary>Indent (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/indent/" />
		[IconCategory("Text Editor Icons")]
		[Description("Indent")]
		Indent = 0xf03c,
		///<summary>Video Camera (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/video-camera/" />
		[IconCategory("Web Application Icons")]
		[Description("Video Camera")]
		VideoCamera = 0xf03d,
		///<summary>Picture Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/picture-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Picture Outlined")]
		PictureOutlined = 0xf03e,
		///<summary>Alias of: PictureOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PictureOutlined" />
		[IconAlias]
		Photo = PictureOutlined,
		///<summary>Alias of: PictureOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PictureOutlined" />
		[IconAlias]
		Image = PictureOutlined,
		///<summary>pencil (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/pencil/" />
		[IconCategory("Web Application Icons")]
		[Description("pencil")]
		Pencil = 0xf040,
		///<summary>map-marker (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/map-marker/" />
		[IconCategory("Web Application Icons")]
		[Description("map-marker")]
		MapMarker = 0xf041,
		///<summary>adjust (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/adjust/" />
		[IconCategory("Web Application Icons")]
		[Description("adjust")]
		Adjust = 0xf042,
		///<summary>tint (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/tint/" />
		[IconCategory("Web Application Icons")]
		[Description("tint")]
		Tint = 0xf043,
		///<summary>Pencil Square Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/pencil-square-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Pencil Square Outlined")]
		PencilSquareOutlined = 0xf044,
		///<summary>Alias of: PencilSquareOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PencilSquareOutlined" />
		[IconAlias]
		Edit = PencilSquareOutlined,
		///<summary>Share Square Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/share-square-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Share Square Outlined")]
		ShareSquareOutlined = 0xf045,
		///<summary>Check Square Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/check-square-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Check Square Outlined")]
		CheckSquareOutlined = 0xf046,
		///<summary>Arrows (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrows/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Arrows")]
		Arrows = 0xf047,
		///<summary>step-backward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/step-backward/" />
		[IconCategory("Video Player Icons")]
		[Description("step-backward")]
		StepBackward = 0xf048,
		///<summary>fast-backward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/fast-backward/" />
		[IconCategory("Video Player Icons")]
		[Description("fast-backward")]
		FastBackward = 0xf049,
		///<summary>backward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/backward/" />
		[IconCategory("Video Player Icons")]
		[Description("backward")]
		Backward = 0xf04a,
		///<summary>play (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/play/" />
		[IconCategory("Video Player Icons")]
		[Description("play")]
		Play = 0xf04b,
		///<summary>pause (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/pause/" />
		[IconCategory("Video Player Icons")]
		[Description("pause")]
		Pause = 0xf04c,
		///<summary>stop (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/stop/" />
		[IconCategory("Video Player Icons")]
		[Description("stop")]
		Stop = 0xf04d,
		///<summary>forward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/forward/" />
		[IconCategory("Video Player Icons")]
		[Description("forward")]
		Forward = 0xf04e,
		///<summary>fast-forward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/fast-forward/" />
		[IconCategory("Video Player Icons")]
		[Description("fast-forward")]
		FastForward = 0xf050,
		///<summary>step-forward (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/step-forward/" />
		[IconCategory("Video Player Icons")]
		[Description("step-forward")]
		StepForward = 0xf051,
		///<summary>eject (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/eject/" />
		[IconCategory("Video Player Icons")]
		[Description("eject")]
		Eject = 0xf052,
		///<summary>chevron-left (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-left/" />
		[IconCategory("Directional Icons")]
		[Description("chevron-left")]
		ChevronLeft = 0xf053,
		///<summary>chevron-right (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-right/" />
		[IconCategory("Directional Icons")]
		[Description("chevron-right")]
		ChevronRight = 0xf054,
		///<summary>Plus Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/plus-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Plus Circle")]
		PlusCircle = 0xf055,
		///<summary>Minus Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/minus-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Minus Circle")]
		MinusCircle = 0xf056,
		///<summary>Times Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/times-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Times Circle")]
		TimesCircle = 0xf057,
		///<summary>Check Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/check-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Check Circle")]
		CheckCircle = 0xf058,
		///<summary>Question Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/question-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Question Circle")]
		QuestionCircle = 0xf059,
		///<summary>Info Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/info-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Info Circle")]
		InfoCircle = 0xf05a,
		///<summary>Crosshairs (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/crosshairs/" />
		[IconCategory("Web Application Icons")]
		[Description("Crosshairs")]
		Crosshairs = 0xf05b,
		///<summary>Times Circle Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/times-circle-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Times Circle Outlined")]
		TimesCircleOutlined = 0xf05c,
		///<summary>Check Circle Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/check-circle-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Check Circle Outlined")]
		CheckCircleOutlined = 0xf05d,
		///<summary>ban (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/ban/" />
		[IconCategory("Web Application Icons")]
		[Description("ban")]
		Ban = 0xf05e,
		///<summary>arrow-left (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-left/" />
		[IconCategory("Directional Icons")]
		[Description("arrow-left")]
		ArrowLeft = 0xf060,
		///<summary>arrow-right (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-right/" />
		[IconCategory("Directional Icons")]
		[Description("arrow-right")]
		ArrowRight = 0xf061,
		///<summary>arrow-up (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-up/" />
		[IconCategory("Directional Icons")]
		[Description("arrow-up")]
		ArrowUp = 0xf062,
		///<summary>arrow-down (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-down/" />
		[IconCategory("Directional Icons")]
		[Description("arrow-down")]
		ArrowDown = 0xf063,
		///<summary>Share (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/share/" />
		[IconCategory("Web Application Icons")]
		[Description("Share")]
		Share = 0xf064,
		///<summary>Alias of: Share</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Share" />
		[IconAlias]
		MailForward = Share,
		///<summary>Expand (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/expand/" />
		[IconCategory("Video Player Icons")]
		[Description("Expand")]
		Expand = 0xf065,
		///<summary>Compress (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/compress/" />
		[IconCategory("Video Player Icons")]
		[Description("Compress")]
		Compress = 0xf066,
		///<summary>plus (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/plus/" />
		[IconCategory("Web Application Icons")]
		[Description("plus")]
		Plus = 0xf067,
		///<summary>minus (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/minus/" />
		[IconCategory("Web Application Icons")]
		[Description("minus")]
		Minus = 0xf068,
		///<summary>asterisk (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/asterisk/" />
		[IconCategory("Web Application Icons")]
		[Description("asterisk")]
		Asterisk = 0xf069,
		///<summary>Exclamation Circle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/exclamation-circle/" />
		[IconCategory("Web Application Icons")]
		[Description("Exclamation Circle")]
		ExclamationCircle = 0xf06a,
		///<summary>gift (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/gift/" />
		[IconCategory("Web Application Icons")]
		[Description("gift")]
		Gift = 0xf06b,
		///<summary>leaf (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/leaf/" />
		[IconCategory("Web Application Icons")]
		[Description("leaf")]
		Leaf = 0xf06c,
		///<summary>fire (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/fire/" />
		[IconCategory("Web Application Icons")]
		[Description("fire")]
		Fire = 0xf06d,
		///<summary>Eye (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/eye/" />
		[IconCategory("Web Application Icons")]
		[Description("Eye")]
		Eye = 0xf06e,
		///<summary>Eye Slash (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/eye-slash/" />
		[IconCategory("Web Application Icons")]
		[Description("Eye Slash")]
		EyeSlash = 0xf070,
		///<summary>Exclamation Triangle (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/exclamation-triangle/" />
		[IconCategory("Web Application Icons")]
		[Description("Exclamation Triangle")]
		ExclamationTriangle = 0xf071,
		///<summary>Alias of: ExclamationTriangle</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ExclamationTriangle" />
		[IconAlias]
		Warning = ExclamationTriangle,
		///<summary>plane (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/plane/" />
		[IconCategory("Web Application Icons")]
		[Description("plane")]
		Plane = 0xf072,
		///<summary>calendar (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/calendar/" />
		[IconCategory("Web Application Icons")]
		[Description("calendar")]
		Calendar = 0xf073,
		///<summary>random (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/random/" />
		[IconCategory("Web Application Icons")]
		[Description("random")]
		Random = 0xf074,
		///<summary>comment (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/comment/" />
		[IconCategory("Web Application Icons")]
		[Description("comment")]
		Comment = 0xf075,
		///<summary>magnet (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/magnet/" />
		[IconCategory("Web Application Icons")]
		[Description("magnet")]
		Magnet = 0xf076,
		///<summary>chevron-up (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-up/" />
		[IconCategory("Directional Icons")]
		[Description("chevron-up")]
		ChevronUp = 0xf077,
		///<summary>chevron-down (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-down/" />
		[IconCategory("Directional Icons")]
		[Description("chevron-down")]
		ChevronDown = 0xf078,
		///<summary>retweet (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/retweet/" />
		[IconCategory("Web Application Icons")]
		[Description("retweet")]
		Retweet = 0xf079,
		///<summary>shopping-cart (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/shopping-cart/" />
		[IconCategory("Web Application Icons")]
		[Description("shopping-cart")]
		ShoppingCart = 0xf07a,
		///<summary>Folder (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/folder/" />
		[IconCategory("Web Application Icons")]
		[Description("Folder")]
		Folder = 0xf07b,
		///<summary>Folder Open (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/folder-open/" />
		[IconCategory("Web Application Icons")]
		[Description("Folder Open")]
		FolderOpen = 0xf07c,
		///<summary>Arrows Vertical (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrows-v/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Arrows Vertical")]
		ArrowsVertical = 0xf07d,
		///<summary>Arrows Horizontal (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrows-h/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Arrows Horizontal")]
		ArrowsHorizontal = 0xf07e,
		///<summary>Bar Chart (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/bar-chart/" />
		[IconCategory("Web Application Icons"),IconCategory("Chart Icons")]
		[Description("Bar Chart")]
		BarChart = 0xf080,
		///<summary>Alias of: BarChart</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BarChart" />
		[IconAlias]
		BarChartO = BarChart,
		///<summary>Twitter Square (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/twitter-square/" />
		[IconCategory("Brand Icons")]
		[Description("Twitter Square")]
		TwitterSquare = 0xf081,
		///<summary>Facebook Square (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/facebook-square/" />
		[IconCategory("Brand Icons")]
		[Description("Facebook Square")]
		FacebookSquare = 0xf082,
		///<summary>camera-retro (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/camera-retro/" />
		[IconCategory("Web Application Icons")]
		[Description("camera-retro")]
		CameraRetro = 0xf083,
		///<summary>key (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/key/" />
		[IconCategory("Web Application Icons")]
		[Description("key")]
		Key = 0xf084,
		///<summary>cogs (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/cogs/" />
		[IconCategory("Web Application Icons")]
		[Description("cogs")]
		Cogs = 0xf085,
		///<summary>Alias of: Cogs</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Cogs" />
		[IconAlias]
		Gears = Cogs,
		///<summary>comments (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/comments/" />
		[IconCategory("Web Application Icons")]
		[Description("comments")]
		Comments = 0xf086,
		///<summary>Thumbs Up Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/thumbs-o-up/" />
		[IconCategory("Web Application Icons")]
		[Description("Thumbs Up Outlined")]
		ThumbsUpOutlined = 0xf087,
		///<summary>Thumbs Down Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/thumbs-o-down/" />
		[IconCategory("Web Application Icons")]
		[Description("Thumbs Down Outlined")]
		ThumbsDownOutlined = 0xf088,
		///<summary>star-half (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/star-half/" />
		[IconCategory("Web Application Icons")]
		[Description("star-half")]
		StarHalf = 0xf089,
		///<summary>Heart Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/heart-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Heart Outlined")]
		HeartOutlined = 0xf08a,
		///<summary>Sign Out (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/sign-out/" />
		[IconCategory("Web Application Icons")]
		[Description("Sign Out")]
		SignOut = 0xf08b,
		///<summary>LinkedIn Square (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/linkedin-square/" />
		[IconCategory("Brand Icons")]
		[Description("LinkedIn Square")]
		LinkedinSquare = 0xf08c,
		///<summary>Thumb Tack (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/thumb-tack/" />
		[IconCategory("Web Application Icons")]
		[Description("Thumb Tack")]
		ThumbTack = 0xf08d,
		///<summary>External Link (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/external-link/" />
		[IconCategory("Web Application Icons")]
		[Description("External Link")]
		ExternalLink = 0xf08e,
		///<summary>Sign In (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/sign-in/" />
		[IconCategory("Web Application Icons")]
		[Description("Sign In")]
		SignIn = 0xf090,
		///<summary>trophy (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/trophy/" />
		[IconCategory("Web Application Icons")]
		[Description("trophy")]
		Trophy = 0xf091,
		///<summary>GitHub Square (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/github-square/" />
		[IconCategory("Brand Icons")]
		[Description("GitHub Square")]
		GithubSquare = 0xf092,
		///<summary>Upload (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/upload/" />
		[IconCategory("Web Application Icons")]
		[Description("Upload")]
		Upload = 0xf093,
		///<summary>Lemon Outlined (created: 1.0)</summary>
		///<see cref="http://fontawesome.io/icon/lemon-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Lemon Outlined")]
		LemonOutlined = 0xf094,
		///<summary>Phone (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/phone/" />
		[IconCategory("Web Application Icons")]
		[Description("Phone")]
		Phone = 0xf095,
		///<summary>Square Outlined (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/square-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Square Outlined")]
		SquareOutlined = 0xf096,
		///<summary>Bookmark Outlined (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/bookmark-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Bookmark Outlined")]
		BookmarkOutlined = 0xf097,
		///<summary>Phone Square (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/phone-square/" />
		[IconCategory("Web Application Icons")]
		[Description("Phone Square")]
		PhoneSquare = 0xf098,
		///<summary>Twitter (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/twitter/" />
		[IconCategory("Brand Icons")]
		[Description("Twitter")]
		Twitter = 0xf099,
		///<summary>Facebook (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/facebook/" />
		[IconCategory("Brand Icons")]
		[Description("Facebook")]
		Facebook = 0xf09a,
		///<summary>GitHub (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/github/" />
		[IconCategory("Brand Icons")]
		[Description("GitHub")]
		Github = 0xf09b,
		///<summary>unlock (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/unlock/" />
		[IconCategory("Web Application Icons")]
		[Description("unlock")]
		Unlock = 0xf09c,
		///<summary>credit-card (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/credit-card/" />
		[IconCategory("Web Application Icons"),IconCategory("Payment Icons")]
		[Description("credit-card")]
		CreditCard = 0xf09d,
		///<summary>rss (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/rss/" />
		[IconCategory("Web Application Icons")]
		[Description("rss")]
		Rss = 0xf09e,
		///<summary>HDD (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/hdd-o/" />
		[IconCategory("Web Application Icons")]
		[Description("HDD")]
		HDD = 0xf0a0,
		///<summary>bullhorn (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/bullhorn/" />
		[IconCategory("Web Application Icons")]
		[Description("bullhorn")]
		Bullhorn = 0xf0a1,
		///<summary>bell (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/bell/" />
		[IconCategory("Web Application Icons")]
		[Description("bell")]
		Bell = 0xf0f3,
		///<summary>certificate (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/certificate/" />
		[IconCategory("Web Application Icons")]
		[Description("certificate")]
		Certificate = 0xf0a3,
		///<summary>Hand Outlined Right (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/hand-o-right/" />
		[IconCategory("Directional Icons")]
		[Description("Hand Outlined Right")]
		HandOutlinedRight = 0xf0a4,
		///<summary>Hand Outlined Left (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/hand-o-left/" />
		[IconCategory("Directional Icons")]
		[Description("Hand Outlined Left")]
		HandOutlinedLeft = 0xf0a5,
		///<summary>Hand Outlined Up (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/hand-o-up/" />
		[IconCategory("Directional Icons")]
		[Description("Hand Outlined Up")]
		HandOutlinedUp = 0xf0a6,
		///<summary>Hand Outlined Down (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/hand-o-down/" />
		[IconCategory("Directional Icons")]
		[Description("Hand Outlined Down")]
		HandOutlinedDown = 0xf0a7,
		///<summary>Arrow Circle Left (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-left/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Left")]
		ArrowCircleLeft = 0xf0a8,
		///<summary>Arrow Circle Right (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-right/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Right")]
		ArrowCircleRight = 0xf0a9,
		///<summary>Arrow Circle Up (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-up/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Up")]
		ArrowCircleUp = 0xf0aa,
		///<summary>Arrow Circle Down (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-down/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Down")]
		ArrowCircleDown = 0xf0ab,
		///<summary>Globe (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/globe/" />
		[IconCategory("Web Application Icons")]
		[Description("Globe")]
		Globe = 0xf0ac,
		///<summary>Wrench (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/wrench/" />
		[IconCategory("Web Application Icons")]
		[Description("Wrench")]
		Wrench = 0xf0ad,
		///<summary>Tasks (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/tasks/" />
		[IconCategory("Web Application Icons")]
		[Description("Tasks")]
		Tasks = 0xf0ae,
		///<summary>Filter (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/filter/" />
		[IconCategory("Web Application Icons")]
		[Description("Filter")]
		Filter = 0xf0b0,
		///<summary>Briefcase (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/briefcase/" />
		[IconCategory("Web Application Icons")]
		[Description("Briefcase")]
		Briefcase = 0xf0b1,
		///<summary>Arrows Alt (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrows-alt/" />
		[IconCategory("Video Player Icons"),IconCategory("Directional Icons")]
		[Description("Arrows Alt")]
		ArrowsAlt = 0xf0b2,
		///<summary>Users (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/users/" />
		[IconCategory("Web Application Icons")]
		[Description("Users")]
		Users = 0xf0c0,
		///<summary>Alias of: Users</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Users" />
		[IconAlias]
		Group = Users,
		///<summary>Link (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/link/" />
		[IconCategory("Text Editor Icons")]
		[Description("Link")]
		Link = 0xf0c1,
		///<summary>Alias of: Link</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Link" />
		[IconAlias]
		Chain = Link,
		///<summary>Cloud (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/cloud/" />
		[IconCategory("Web Application Icons")]
		[Description("Cloud")]
		Cloud = 0xf0c2,
		///<summary>Flask (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/flask/" />
		[IconCategory("Web Application Icons")]
		[Description("Flask")]
		Flask = 0xf0c3,
		///<summary>Scissors (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/scissors/" />
		[IconCategory("Text Editor Icons")]
		[Description("Scissors")]
		Scissors = 0xf0c4,
		///<summary>Alias of: Scissors</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Scissors" />
		[IconAlias]
		Cut = Scissors,
		///<summary>Files Outlined (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/files-o/" />
		[IconCategory("Text Editor Icons")]
		[Description("Files Outlined")]
		FilesOutlined = 0xf0c5,
		///<summary>Alias of: FilesOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FilesOutlined" />
		[IconAlias]
		Copy = FilesOutlined,
		///<summary>Paperclip (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/paperclip/" />
		[IconCategory("Text Editor Icons")]
		[Description("Paperclip")]
		Paperclip = 0xf0c6,
		///<summary>Floppy Outlined (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/floppy-o/" />
		[IconCategory("Text Editor Icons")]
		[Description("Floppy Outlined")]
		FloppyOutlined = 0xf0c7,
		///<summary>Alias of: FloppyOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FloppyOutlined" />
		[IconAlias]
		Save = FloppyOutlined,
		///<summary>Square (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/square/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Square")]
		Square = 0xf0c8,
		///<summary>Bars (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/bars/" />
		[IconCategory("Web Application Icons")]
		[Description("Bars")]
		Bars = 0xf0c9,
		///<summary>Alias of: Bars</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bars" />
		[IconAlias]
		Navicon = Bars,
		///<summary>Alias of: Bars</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bars" />
		[IconAlias]
		Reorder = Bars,
		///<summary>list-ul (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/list-ul/" />
		[IconCategory("Text Editor Icons")]
		[Description("list-ul")]
		ListUl = 0xf0ca,
		///<summary>list-ol (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/list-ol/" />
		[IconCategory("Text Editor Icons")]
		[Description("list-ol")]
		ListOl = 0xf0cb,
		///<summary>Strikethrough (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/strikethrough/" />
		[IconCategory("Text Editor Icons")]
		[Description("Strikethrough")]
		Strikethrough = 0xf0cc,
		///<summary>Underline (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/underline/" />
		[IconCategory("Text Editor Icons")]
		[Description("Underline")]
		Underline = 0xf0cd,
		///<summary>table (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/table/" />
		[IconCategory("Text Editor Icons")]
		[Description("table")]
		Table = 0xf0ce,
		///<summary>magic (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/magic/" />
		[IconCategory("Web Application Icons")]
		[Description("magic")]
		Magic = 0xf0d0,
		///<summary>truck (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/truck/" />
		[IconCategory("Web Application Icons")]
		[Description("truck")]
		Truck = 0xf0d1,
		///<summary>Pinterest (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/pinterest/" />
		[IconCategory("Brand Icons")]
		[Description("Pinterest")]
		Pinterest = 0xf0d2,
		///<summary>Pinterest Square (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/pinterest-square/" />
		[IconCategory("Brand Icons")]
		[Description("Pinterest Square")]
		PinterestSquare = 0xf0d3,
		///<summary>Google Plus Square (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/google-plus-square/" />
		[IconCategory("Brand Icons")]
		[Description("Google Plus Square")]
		GooglePlusSquare = 0xf0d4,
		///<summary>Google Plus (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/google-plus/" />
		[IconCategory("Brand Icons")]
		[Description("Google Plus")]
		GooglePlus = 0xf0d5,
		///<summary>Money (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/money/" />
		[IconCategory("Web Application Icons"),IconCategory("Currency Icons")]
		[Description("Money")]
		Money = 0xf0d6,
		///<summary>Caret Down (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/caret-down/" />
		[IconCategory("Directional Icons")]
		[Description("Caret Down")]
		CaretDown = 0xf0d7,
		///<summary>Caret Up (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/caret-up/" />
		[IconCategory("Directional Icons")]
		[Description("Caret Up")]
		CaretUp = 0xf0d8,
		///<summary>Caret Left (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/caret-left/" />
		[IconCategory("Directional Icons")]
		[Description("Caret Left")]
		CaretLeft = 0xf0d9,
		///<summary>Caret Right (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/caret-right/" />
		[IconCategory("Directional Icons")]
		[Description("Caret Right")]
		CaretRight = 0xf0da,
		///<summary>Columns (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/columns/" />
		[IconCategory("Text Editor Icons")]
		[Description("Columns")]
		Columns = 0xf0db,
		///<summary>Sort (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/sort/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort")]
		Sort = 0xf0dc,
		///<summary>Alias of: Sort</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Sort" />
		[IconAlias]
		Unsorted = Sort,
		///<summary>Sort Descending (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/sort-desc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Descending")]
		SortDescending = 0xf0dd,
		///<summary>Alias of: SortDescending</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.SortDescending" />
		[IconAlias]
		SortDown = SortDescending,
		///<summary>Sort Ascending (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/sort-asc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Ascending")]
		SortAscending = 0xf0de,
		///<summary>Alias of: SortAscending</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.SortAscending" />
		[IconAlias]
		SortUp = SortAscending,
		///<summary>Envelope (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/envelope/" />
		[IconCategory("Web Application Icons")]
		[Description("Envelope")]
		Envelope = 0xf0e0,
		///<summary>LinkedIn (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/linkedin/" />
		[IconCategory("Brand Icons")]
		[Description("LinkedIn")]
		Linkedin = 0xf0e1,
		///<summary>Undo (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/undo/" />
		[IconCategory("Text Editor Icons")]
		[Description("Undo")]
		Undo = 0xf0e2,
		///<summary>Alias of: Undo</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Undo" />
		[IconAlias]
		RotateLeft = Undo,
		///<summary>Gavel (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/gavel/" />
		[IconCategory("Web Application Icons")]
		[Description("Gavel")]
		Gavel = 0xf0e3,
		///<summary>Alias of: Gavel</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Gavel" />
		[IconAlias]
		Legal = Gavel,
		///<summary>Tachometer (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/tachometer/" />
		[IconCategory("Web Application Icons")]
		[Description("Tachometer")]
		Tachometer = 0xf0e4,
		///<summary>Alias of: Tachometer</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Tachometer" />
		[IconAlias]
		Dashboard = Tachometer,
		///<summary>comment-o (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/comment-o/" />
		[IconCategory("Web Application Icons")]
		[Description("comment-o")]
		CommentO = 0xf0e5,
		///<summary>comments-o (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/comments-o/" />
		[IconCategory("Web Application Icons")]
		[Description("comments-o")]
		CommentsO = 0xf0e6,
		///<summary>Lightning Bolt (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/bolt/" />
		[IconCategory("Web Application Icons")]
		[Description("Lightning Bolt")]
		LightningBolt = 0xf0e7,
		///<summary>Alias of: LightningBolt</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LightningBolt" />
		[IconAlias]
		Flash = LightningBolt,
		///<summary>Sitemap (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/sitemap/" />
		[IconCategory("Web Application Icons")]
		[Description("Sitemap")]
		Sitemap = 0xf0e8,
		///<summary>Umbrella (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/umbrella/" />
		[IconCategory("Web Application Icons")]
		[Description("Umbrella")]
		Umbrella = 0xf0e9,
		///<summary>Clipboard (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/clipboard/" />
		[IconCategory("Text Editor Icons")]
		[Description("Clipboard")]
		Clipboard = 0xf0ea,
		///<summary>Alias of: Clipboard</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Clipboard" />
		[IconAlias]
		Paste = Clipboard,
		///<summary>Lightbulb Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/lightbulb-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Lightbulb Outlined")]
		LightbulbOutlined = 0xf0eb,
		///<summary>Exchange (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/exchange/" />
		[IconCategory("Web Application Icons")]
		[Description("Exchange")]
		Exchange = 0xf0ec,
		///<summary>Cloud Download (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/cloud-download/" />
		[IconCategory("Web Application Icons")]
		[Description("Cloud Download")]
		CloudDownload = 0xf0ed,
		///<summary>Cloud Upload (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/cloud-upload/" />
		[IconCategory("Web Application Icons")]
		[Description("Cloud Upload")]
		CloudUpload = 0xf0ee,
		///<summary>user-md (created: 2.0)</summary>
		///<see cref="http://fontawesome.io/icon/user-md/" />
		[IconCategory("Medical Icons")]
		[Description("user-md")]
		UserMd = 0xf0f0,
		///<summary>Stethoscope (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/stethoscope/" />
		[IconCategory("Medical Icons")]
		[Description("Stethoscope")]
		Stethoscope = 0xf0f1,
		///<summary>Suitcase (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/suitcase/" />
		[IconCategory("Web Application Icons")]
		[Description("Suitcase")]
		Suitcase = 0xf0f2,
		///<summary>Bell Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/bell-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Bell Outlined")]
		BellOutlined = 0xf0a2,
		///<summary>Coffee (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/coffee/" />
		[IconCategory("Web Application Icons")]
		[Description("Coffee")]
		Coffee = 0xf0f4,
		///<summary>Cutlery (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/cutlery/" />
		[IconCategory("Web Application Icons")]
		[Description("Cutlery")]
		Cutlery = 0xf0f5,
		///<summary>File Text Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/file-text-o/" />
		[IconCategory("Text Editor Icons"),IconCategory("File Type Icons")]
		[Description("File Text Outlined")]
		FileTextOutlined = 0xf0f6,
		///<summary>Building Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/building-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Building Outlined")]
		BuildingOutlined = 0xf0f7,
		///<summary>hospital Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/hospital-o/" />
		[IconCategory("Medical Icons")]
		[Description("hospital Outlined")]
		HospitalOutlined = 0xf0f8,
		///<summary>ambulance (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/ambulance/" />
		[IconCategory("Medical Icons")]
		[Description("ambulance")]
		Ambulance = 0xf0f9,
		///<summary>medkit (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/medkit/" />
		[IconCategory("Medical Icons")]
		[Description("medkit")]
		Medkit = 0xf0fa,
		///<summary>fighter-jet (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/fighter-jet/" />
		[IconCategory("Web Application Icons")]
		[Description("fighter-jet")]
		FighterJet = 0xf0fb,
		///<summary>beer (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/beer/" />
		[IconCategory("Web Application Icons")]
		[Description("beer")]
		Beer = 0xf0fc,
		///<summary>H Square (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/h-square/" />
		[IconCategory("Medical Icons")]
		[Description("H Square")]
		HSquare = 0xf0fd,
		///<summary>Plus Square (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/plus-square/" />
		[IconCategory("Medical Icons"),IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Plus Square")]
		PlusSquare = 0xf0fe,
		///<summary>Angle Double Left (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-double-left/" />
		[IconCategory("Directional Icons")]
		[Description("Angle Double Left")]
		AngleDoubleLeft = 0xf100,
		///<summary>Angle Double Right (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-double-right/" />
		[IconCategory("Directional Icons")]
		[Description("Angle Double Right")]
		AngleDoubleRight = 0xf101,
		///<summary>Angle Double Up (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-double-up/" />
		[IconCategory("Directional Icons")]
		[Description("Angle Double Up")]
		AngleDoubleUp = 0xf102,
		///<summary>Angle Double Down (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-double-down/" />
		[IconCategory("Directional Icons")]
		[Description("Angle Double Down")]
		AngleDoubleDown = 0xf103,
		///<summary>angle-left (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-left/" />
		[IconCategory("Directional Icons")]
		[Description("angle-left")]
		AngleLeft = 0xf104,
		///<summary>angle-right (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-right/" />
		[IconCategory("Directional Icons")]
		[Description("angle-right")]
		AngleRight = 0xf105,
		///<summary>angle-up (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-up/" />
		[IconCategory("Directional Icons")]
		[Description("angle-up")]
		AngleUp = 0xf106,
		///<summary>angle-down (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/angle-down/" />
		[IconCategory("Directional Icons")]
		[Description("angle-down")]
		AngleDown = 0xf107,
		///<summary>Desktop (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/desktop/" />
		[IconCategory("Web Application Icons")]
		[Description("Desktop")]
		Desktop = 0xf108,
		///<summary>Laptop (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/laptop/" />
		[IconCategory("Web Application Icons")]
		[Description("Laptop")]
		Laptop = 0xf109,
		///<summary>tablet (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/tablet/" />
		[IconCategory("Web Application Icons")]
		[Description("tablet")]
		Tablet = 0xf10a,
		///<summary>Mobile Phone (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/mobile/" />
		[IconCategory("Web Application Icons")]
		[Description("Mobile Phone")]
		MobilePhone = 0xf10b,
		///<summary>Circle Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/circle-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Circle Outlined")]
		CircleOutlined = 0xf10c,
		///<summary>quote-left (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/quote-left/" />
		[IconCategory("Web Application Icons")]
		[Description("quote-left")]
		QuoteLeft = 0xf10d,
		///<summary>quote-right (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/quote-right/" />
		[IconCategory("Web Application Icons")]
		[Description("quote-right")]
		QuoteRight = 0xf10e,
		///<summary>Spinner (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/spinner/" />
		[IconCategory("Web Application Icons"),IconCategory("Spinner Icons")]
		[Description("Spinner")]
		Spinner = 0xf110,
		///<summary>Circle (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/circle/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Circle")]
		Circle = 0xf111,
		///<summary>Reply (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/reply/" />
		[IconCategory("Web Application Icons")]
		[Description("Reply")]
		Reply = 0xf112,
		///<summary>Alias of: Reply</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Reply" />
		[IconAlias]
		MailReply = Reply,
		///<summary>GitHub Alt (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/github-alt/" />
		[IconCategory("Brand Icons")]
		[Description("GitHub Alt")]
		GithubAlt = 0xf113,
		///<summary>Folder Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/folder-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Folder Outlined")]
		FolderOutlined = 0xf114,
		///<summary>Folder Open Outlined (created: 3.0)</summary>
		///<see cref="http://fontawesome.io/icon/folder-open-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Folder Open Outlined")]
		FolderOpenOutlined = 0xf115,
		///<summary>Smile Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/smile-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Smile Outlined")]
		SmileOutlined = 0xf118,
		///<summary>Frown Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/frown-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Frown Outlined")]
		FrownOutlined = 0xf119,
		///<summary>Meh Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/meh-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Meh Outlined")]
		MehOutlined = 0xf11a,
		///<summary>Gamepad (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/gamepad/" />
		[IconCategory("Web Application Icons")]
		[Description("Gamepad")]
		Gamepad = 0xf11b,
		///<summary>Keyboard Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/keyboard-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Keyboard Outlined")]
		KeyboardOutlined = 0xf11c,
		///<summary>Flag Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/flag-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Flag Outlined")]
		FlagOutlined = 0xf11d,
		///<summary>flag-checkered (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/flag-checkered/" />
		[IconCategory("Web Application Icons")]
		[Description("flag-checkered")]
		FlagCheckered = 0xf11e,
		///<summary>Terminal (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/terminal/" />
		[IconCategory("Web Application Icons")]
		[Description("Terminal")]
		Terminal = 0xf120,
		///<summary>Code (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/code/" />
		[IconCategory("Web Application Icons")]
		[Description("Code")]
		Code = 0xf121,
		///<summary>reply-all (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/reply-all/" />
		[IconCategory("Web Application Icons")]
		[Description("reply-all")]
		ReplyAll = 0xf122,
		///<summary>Alias of: ReplyAll</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ReplyAll" />
		[IconAlias]
		MailReplyAll = ReplyAll,
		///<summary>Star Half Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/star-half-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Star Half Outlined")]
		StarHalfOutlined = 0xf123,
		///<summary>Alias of: StarHalfOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.StarHalfOutlined" />
		[IconAlias]
		StarHalfEmpty = StarHalfOutlined,
		///<summary>Alias of: StarHalfOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.StarHalfOutlined" />
		[IconAlias]
		StarHalfFull = StarHalfOutlined,
		///<summary>location-arrow (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/location-arrow/" />
		[IconCategory("Web Application Icons")]
		[Description("location-arrow")]
		LocationArrow = 0xf124,
		///<summary>crop (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/crop/" />
		[IconCategory("Web Application Icons")]
		[Description("crop")]
		Crop = 0xf125,
		///<summary>code-fork (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/code-fork/" />
		[IconCategory("Web Application Icons")]
		[Description("code-fork")]
		CodeFork = 0xf126,
		///<summary>Chain Broken (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/chain-broken/" />
		[IconCategory("Text Editor Icons")]
		[Description("Chain Broken")]
		ChainBroken = 0xf127,
		///<summary>Alias of: ChainBroken</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ChainBroken" />
		[IconAlias]
		Unlink = ChainBroken,
		///<summary>Question (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/question/" />
		[IconCategory("Web Application Icons")]
		[Description("Question")]
		Question = 0xf128,
		///<summary>Info (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/info/" />
		[IconCategory("Web Application Icons")]
		[Description("Info")]
		Info = 0xf129,
		///<summary>exclamation (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/exclamation/" />
		[IconCategory("Web Application Icons")]
		[Description("exclamation")]
		Exclamation = 0xf12a,
		///<summary>superscript (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/superscript/" />
		[IconCategory("Text Editor Icons")]
		[Description("superscript")]
		Superscript = 0xf12b,
		///<summary>subscript (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/subscript/" />
		[IconCategory("Text Editor Icons")]
		[Description("subscript")]
		Subscript = 0xf12c,
		///<summary>eraser (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/eraser/" />
		[IconCategory("Text Editor Icons"),IconCategory("Web Application Icons")]
		[Description("eraser")]
		Eraser = 0xf12d,
		///<summary>Puzzle Piece (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/puzzle-piece/" />
		[IconCategory("Web Application Icons")]
		[Description("Puzzle Piece")]
		PuzzlePiece = 0xf12e,
		///<summary>microphone (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/microphone/" />
		[IconCategory("Web Application Icons")]
		[Description("microphone")]
		Microphone = 0xf130,
		///<summary>Microphone Slash (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/microphone-slash/" />
		[IconCategory("Web Application Icons")]
		[Description("Microphone Slash")]
		MicrophoneSlash = 0xf131,
		///<summary>shield (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/shield/" />
		[IconCategory("Web Application Icons")]
		[Description("shield")]
		Shield = 0xf132,
		///<summary>calendar-o (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/calendar-o/" />
		[IconCategory("Web Application Icons")]
		[Description("calendar-o")]
		CalendarO = 0xf133,
		///<summary>fire-extinguisher (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/fire-extinguisher/" />
		[IconCategory("Web Application Icons")]
		[Description("fire-extinguisher")]
		FireExtinguisher = 0xf134,
		///<summary>rocket (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/rocket/" />
		[IconCategory("Web Application Icons")]
		[Description("rocket")]
		Rocket = 0xf135,
		///<summary>MaxCDN (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/maxcdn/" />
		[IconCategory("Brand Icons")]
		[Description("MaxCDN")]
		Maxcdn = 0xf136,
		///<summary>Chevron Circle Left (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-circle-left/" />
		[IconCategory("Directional Icons")]
		[Description("Chevron Circle Left")]
		ChevronCircleLeft = 0xf137,
		///<summary>Chevron Circle Right (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-circle-right/" />
		[IconCategory("Directional Icons")]
		[Description("Chevron Circle Right")]
		ChevronCircleRight = 0xf138,
		///<summary>Chevron Circle Up (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-circle-up/" />
		[IconCategory("Directional Icons")]
		[Description("Chevron Circle Up")]
		ChevronCircleUp = 0xf139,
		///<summary>Chevron Circle Down (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/chevron-circle-down/" />
		[IconCategory("Directional Icons")]
		[Description("Chevron Circle Down")]
		ChevronCircleDown = 0xf13a,
		///<summary>HTML 5 Logo (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/html5/" />
		[IconCategory("Brand Icons")]
		[Description("HTML 5 Logo")]
		HTML5Logo = 0xf13b,
		///<summary>CSS 3 Logo (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/css3/" />
		[IconCategory("Brand Icons")]
		[Description("CSS 3 Logo")]
		CSS3Logo = 0xf13c,
		///<summary>Anchor (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/anchor/" />
		[IconCategory("Web Application Icons")]
		[Description("Anchor")]
		Anchor = 0xf13d,
		///<summary>Unlock Alt (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/unlock-alt/" />
		[IconCategory("Web Application Icons")]
		[Description("Unlock Alt")]
		UnlockAlt = 0xf13e,
		///<summary>Bullseye (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/bullseye/" />
		[IconCategory("Web Application Icons")]
		[Description("Bullseye")]
		Bullseye = 0xf140,
		///<summary>Ellipsis Horizontal (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/ellipsis-h/" />
		[IconCategory("Web Application Icons")]
		[Description("Ellipsis Horizontal")]
		EllipsisHorizontal = 0xf141,
		///<summary>Ellipsis Vertical (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/ellipsis-v/" />
		[IconCategory("Web Application Icons")]
		[Description("Ellipsis Vertical")]
		EllipsisVertical = 0xf142,
		///<summary>RSS Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/rss-square/" />
		[IconCategory("Web Application Icons")]
		[Description("RSS Square")]
		RSSSquare = 0xf143,
		///<summary>Play Circle (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/play-circle/" />
		[IconCategory("Video Player Icons")]
		[Description("Play Circle")]
		PlayCircle = 0xf144,
		///<summary>Ticket (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/ticket/" />
		[IconCategory("Web Application Icons")]
		[Description("Ticket")]
		Ticket = 0xf145,
		///<summary>Minus Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/minus-square/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Minus Square")]
		MinusSquare = 0xf146,
		///<summary>Minus Square Outlined (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/minus-square-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Minus Square Outlined")]
		MinusSquareOutlined = 0xf147,
		///<summary>Level Up (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/level-up/" />
		[IconCategory("Web Application Icons")]
		[Description("Level Up")]
		LevelUp = 0xf148,
		///<summary>Level Down (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/level-down/" />
		[IconCategory("Web Application Icons")]
		[Description("Level Down")]
		LevelDown = 0xf149,
		///<summary>Check Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/check-square/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Check Square")]
		CheckSquare = 0xf14a,
		///<summary>Pencil Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/pencil-square/" />
		[IconCategory("Web Application Icons")]
		[Description("Pencil Square")]
		PencilSquare = 0xf14b,
		///<summary>External Link Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/external-link-square/" />
		[IconCategory("Web Application Icons")]
		[Description("External Link Square")]
		ExternalLinkSquare = 0xf14c,
		///<summary>Share Square (created: 3.1)</summary>
		///<see cref="http://fontawesome.io/icon/share-square/" />
		[IconCategory("Web Application Icons")]
		[Description("Share Square")]
		ShareSquare = 0xf14d,
		///<summary>Compass (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/compass/" />
		[IconCategory("Web Application Icons")]
		[Description("Compass")]
		Compass = 0xf14e,
		///<summary>Caret Square Outlined Down (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/caret-square-o-down/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Caret Square Outlined Down")]
		CaretSquareOutlinedDown = 0xf150,
		///<summary>Alias of: CaretSquareOutlinedDown</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlinedDown" />
		[IconAlias]
		ToggleDown = CaretSquareOutlinedDown,
		///<summary>Caret Square Outlined Up (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/caret-square-o-up/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Caret Square Outlined Up")]
		CaretSquareOutlinedUp = 0xf151,
		///<summary>Alias of: CaretSquareOutlinedUp</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlinedUp" />
		[IconAlias]
		ToggleUp = CaretSquareOutlinedUp,
		///<summary>Caret Square Outlined Right (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/caret-square-o-right/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Caret Square Outlined Right")]
		CaretSquareOutlinedRight = 0xf152,
		///<summary>Alias of: CaretSquareOutlinedRight</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlinedRight" />
		[IconAlias]
		ToggleRight = CaretSquareOutlinedRight,
		///<summary>Euro (EUR) (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/eur/" />
		[IconCategory("Currency Icons")]
		[Description("Euro (EUR)")]
		Euro = 0xf153,
		///<summary>GBP (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/gbp/" />
		[IconCategory("Currency Icons")]
		[Description("GBP")]
		GBP = 0xf154,
		///<summary>US Dollar (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/usd/" />
		[IconCategory("Currency Icons")]
		[Description("US Dollar")]
		USDollar = 0xf155,
		///<summary>Alias of: USDollar</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.USDollar" />
		[IconAlias]
		Dollar = USDollar,
		///<summary>Indian Rupee (INR) (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/inr/" />
		[IconCategory("Currency Icons")]
		[Description("Indian Rupee (INR)")]
		IndianRupee = 0xf156,
		///<summary>Alias of: IndianRupee</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.IndianRupee" />
		[IconAlias]
		Rupee = IndianRupee,
		///<summary>Japanese Yen (JPY) (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/jpy/" />
		[IconCategory("Currency Icons")]
		[Description("Japanese Yen (JPY)")]
		JapaneseYen = 0xf157,
		///<summary>Alias of: JapaneseYen</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.JapaneseYen" />
		[IconAlias]
		Cny = JapaneseYen,
		///<summary>Alias of: JapaneseYen</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.JapaneseYen" />
		[IconAlias]
		Rmb = JapaneseYen,
		///<summary>Alias of: JapaneseYen</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.JapaneseYen" />
		[IconAlias]
		Yen = JapaneseYen,
		///<summary>Russian Ruble (RUB) (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/rub/" />
		[IconCategory("Currency Icons")]
		[Description("Russian Ruble (RUB)")]
		RussianRuble = 0xf158,
		///<summary>Alias of: RussianRuble</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.RussianRuble" />
		[IconAlias]
		Ruble = RussianRuble,
		///<summary>Alias of: RussianRuble</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.RussianRuble" />
		[IconAlias]
		Rouble = RussianRuble,
		///<summary>Korean Won (KRW) (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/krw/" />
		[IconCategory("Currency Icons")]
		[Description("Korean Won (KRW)")]
		KoreanWon = 0xf159,
		///<summary>Alias of: KoreanWon</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.KoreanWon" />
		[IconAlias]
		Won = KoreanWon,
		///<summary>Bitcoin (BTC) (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/btc/" />
		[IconCategory("Currency Icons"),IconCategory("Brand Icons")]
		[Description("Bitcoin (BTC)")]
		Bitcoin = 0xf15a,
		///<summary>File (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/file/" />
		[IconCategory("Text Editor Icons"),IconCategory("File Type Icons")]
		[Description("File")]
		File = 0xf15b,
		///<summary>File Text (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/file-text/" />
		[IconCategory("Text Editor Icons"),IconCategory("File Type Icons")]
		[Description("File Text")]
		FileText = 0xf15c,
		///<summary>Sort Alpha Ascending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-alpha-asc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Alpha Ascending")]
		SortAlphaAscending = 0xf15d,
		///<summary>Sort Alpha Descending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-alpha-desc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Alpha Descending")]
		SortAlphaDescending = 0xf15e,
		///<summary>Sort Amount Ascending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-amount-asc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Amount Ascending")]
		SortAmountAscending = 0xf160,
		///<summary>Sort Amount Descending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-amount-desc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Amount Descending")]
		SortAmountDescending = 0xf161,
		///<summary>Sort Numeric Ascending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-numeric-asc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Numeric Ascending")]
		SortNumericAscending = 0xf162,
		///<summary>Sort Numeric Descending (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sort-numeric-desc/" />
		[IconCategory("Web Application Icons")]
		[Description("Sort Numeric Descending")]
		SortNumericDescending = 0xf163,
		///<summary>thumbs-up (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/thumbs-up/" />
		[IconCategory("Web Application Icons")]
		[Description("thumbs-up")]
		ThumbsUp = 0xf164,
		///<summary>thumbs-down (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/thumbs-down/" />
		[IconCategory("Web Application Icons")]
		[Description("thumbs-down")]
		ThumbsDown = 0xf165,
		///<summary>YouTube Square (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/youtube-square/" />
		[IconCategory("Brand Icons")]
		[Description("YouTube Square")]
		YoutubeSquare = 0xf166,
		///<summary>YouTube (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/youtube/" />
		[IconCategory("Brand Icons")]
		[Description("YouTube")]
		Youtube = 0xf167,
		///<summary>Xing (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/xing/" />
		[IconCategory("Brand Icons")]
		[Description("Xing")]
		Xing = 0xf168,
		///<summary>Xing Square (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/xing-square/" />
		[IconCategory("Brand Icons")]
		[Description("Xing Square")]
		XingSquare = 0xf169,
		///<summary>YouTube Play (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/youtube-play/" />
		[IconCategory("Brand Icons"),IconCategory("Video Player Icons")]
		[Description("YouTube Play")]
		YoutubePlay = 0xf16a,
		///<summary>Dropbox (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/dropbox/" />
		[IconCategory("Brand Icons")]
		[Description("Dropbox")]
		Dropbox = 0xf16b,
		///<summary>Stack Overflow (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/stack-overflow/" />
		[IconCategory("Brand Icons")]
		[Description("Stack Overflow")]
		StackOverflow = 0xf16c,
		///<summary>Instagram (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/instagram/" />
		[IconCategory("Brand Icons")]
		[Description("Instagram")]
		Instagram = 0xf16d,
		///<summary>Flickr (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/flickr/" />
		[IconCategory("Brand Icons")]
		[Description("Flickr")]
		Flickr = 0xf16e,
		///<summary>App.net (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/adn/" />
		[IconCategory("Brand Icons")]
		[Description("App.net")]
		AppNet = 0xf170,
		///<summary>Bitbucket (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/bitbucket/" />
		[IconCategory("Brand Icons")]
		[Description("Bitbucket")]
		Bitbucket = 0xf171,
		///<summary>Bitbucket Square (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/bitbucket-square/" />
		[IconCategory("Brand Icons")]
		[Description("Bitbucket Square")]
		BitbucketSquare = 0xf172,
		///<summary>Tumblr (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/tumblr/" />
		[IconCategory("Brand Icons")]
		[Description("Tumblr")]
		Tumblr = 0xf173,
		///<summary>Tumblr Square (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/tumblr-square/" />
		[IconCategory("Brand Icons")]
		[Description("Tumblr Square")]
		TumblrSquare = 0xf174,
		///<summary>Long Arrow Down (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/long-arrow-down/" />
		[IconCategory("Directional Icons")]
		[Description("Long Arrow Down")]
		LongArrowDown = 0xf175,
		///<summary>Long Arrow Up (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/long-arrow-up/" />
		[IconCategory("Directional Icons")]
		[Description("Long Arrow Up")]
		LongArrowUp = 0xf176,
		///<summary>Long Arrow Left (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/long-arrow-left/" />
		[IconCategory("Directional Icons")]
		[Description("Long Arrow Left")]
		LongArrowLeft = 0xf177,
		///<summary>Long Arrow Right (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/long-arrow-right/" />
		[IconCategory("Directional Icons")]
		[Description("Long Arrow Right")]
		LongArrowRight = 0xf178,
		///<summary>Apple (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/apple/" />
		[IconCategory("Brand Icons")]
		[Description("Apple")]
		Apple = 0xf179,
		///<summary>Windows (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/windows/" />
		[IconCategory("Brand Icons")]
		[Description("Windows")]
		Windows = 0xf17a,
		///<summary>Android (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/android/" />
		[IconCategory("Brand Icons")]
		[Description("Android")]
		Android = 0xf17b,
		///<summary>Linux (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/linux/" />
		[IconCategory("Brand Icons")]
		[Description("Linux")]
		Linux = 0xf17c,
		///<summary>Dribbble (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/dribbble/" />
		[IconCategory("Brand Icons")]
		[Description("Dribbble")]
		Dribbble = 0xf17d,
		///<summary>Skype (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/skype/" />
		[IconCategory("Brand Icons")]
		[Description("Skype")]
		Skype = 0xf17e,
		///<summary>Foursquare (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/foursquare/" />
		[IconCategory("Brand Icons")]
		[Description("Foursquare")]
		Foursquare = 0xf180,
		///<summary>Trello (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/trello/" />
		[IconCategory("Brand Icons")]
		[Description("Trello")]
		Trello = 0xf181,
		///<summary>Female (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/female/" />
		[IconCategory("Web Application Icons")]
		[Description("Female")]
		Female = 0xf182,
		///<summary>Male (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/male/" />
		[IconCategory("Web Application Icons")]
		[Description("Male")]
		Male = 0xf183,
		///<summary>Gittip (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/gittip/" />
		[IconCategory("Brand Icons")]
		[Description("Gittip")]
		Gittip = 0xf184,
		///<summary>Sun Outlined (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/sun-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Sun Outlined")]
		SunOutlined = 0xf185,
		///<summary>Moon Outlined (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/moon-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Moon Outlined")]
		MoonOutlined = 0xf186,
		///<summary>Archive (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/archive/" />
		[IconCategory("Web Application Icons")]
		[Description("Archive")]
		Archive = 0xf187,
		///<summary>Bug (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/bug/" />
		[IconCategory("Web Application Icons")]
		[Description("Bug")]
		Bug = 0xf188,
		///<summary>VK (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/vk/" />
		[IconCategory("Brand Icons")]
		[Description("VK")]
		VK = 0xf189,
		///<summary>Weibo (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/weibo/" />
		[IconCategory("Brand Icons")]
		[Description("Weibo")]
		Weibo = 0xf18a,
		///<summary>Renren (created: 3.2)</summary>
		///<see cref="http://fontawesome.io/icon/renren/" />
		[IconCategory("Brand Icons")]
		[Description("Renren")]
		Renren = 0xf18b,
		///<summary>Pagelines (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/pagelines/" />
		[IconCategory("Brand Icons")]
		[Description("Pagelines")]
		Pagelines = 0xf18c,
		///<summary>Stack Exchange (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/stack-exchange/" />
		[IconCategory("Brand Icons")]
		[Description("Stack Exchange")]
		StackExchange = 0xf18d,
		///<summary>Arrow Circle Outlined Right (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-o-right/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Outlined Right")]
		ArrowCircleOutlinedRight = 0xf18e,
		///<summary>Arrow Circle Outlined Left (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/arrow-circle-o-left/" />
		[IconCategory("Directional Icons")]
		[Description("Arrow Circle Outlined Left")]
		ArrowCircleOutlinedLeft = 0xf190,
		///<summary>Caret Square Outlined Left (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/caret-square-o-left/" />
		[IconCategory("Web Application Icons"),IconCategory("Directional Icons")]
		[Description("Caret Square Outlined Left")]
		CaretSquareOutlinedLeft = 0xf191,
		///<summary>Alias of: CaretSquareOutlinedLeft</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlinedLeft" />
		[IconAlias]
		ToggleLeft = CaretSquareOutlinedLeft,
		///<summary>Dot Circle O (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/dot-circle-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Dot Circle O")]
		DotCircleO = 0xf192,
		///<summary>Wheelchair (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/wheelchair/" />
		[IconCategory("Web Application Icons"),IconCategory("Medical Icons")]
		[Description("Wheelchair")]
		Wheelchair = 0xf193,
		///<summary>Vimeo Square (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/vimeo-square/" />
		[IconCategory("Brand Icons")]
		[Description("Vimeo Square")]
		VimeoSquare = 0xf194,
		///<summary>Turkish Lira (TRY) (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/try/" />
		[IconCategory("Currency Icons")]
		[Description("Turkish Lira (TRY)")]
		TurkishLira = 0xf195,
		///<summary>Plus Square Outlined (created: 4.0)</summary>
		///<see cref="http://fontawesome.io/icon/plus-square-o/" />
		[IconCategory("Web Application Icons"),IconCategory("Form Control Icons")]
		[Description("Plus Square Outlined")]
		PlusSquareOutlined = 0xf196,
		///<summary>Space Shuttle (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/space-shuttle/" />
		[IconCategory("Web Application Icons")]
		[Description("Space Shuttle")]
		SpaceShuttle = 0xf197,
		///<summary>Slack Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/slack/" />
		[IconCategory("Brand Icons")]
		[Description("Slack Logo")]
		SlackLogo = 0xf198,
		///<summary>Envelope Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/envelope-square/" />
		[IconCategory("Web Application Icons")]
		[Description("Envelope Square")]
		EnvelopeSquare = 0xf199,
		///<summary>Wordpress Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/wordpress/" />
		[IconCategory("Brand Icons")]
		[Description("Wordpress Logo")]
		WordpressLogo = 0xf19a,
		///<summary>OpenID (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/openid/" />
		[IconCategory("Brand Icons")]
		[Description("OpenID")]
		Openid = 0xf19b,
		///<summary>University (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/university/" />
		[IconCategory("Web Application Icons")]
		[Description("University")]
		University = 0xf19c,
		///<summary>Alias of: University</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.University" />
		[IconAlias]
		Institution = University,
		///<summary>Alias of: University</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.University" />
		[IconAlias]
		Bank = University,
		///<summary>Graduation Cap (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/graduation-cap/" />
		[IconCategory("Web Application Icons")]
		[Description("Graduation Cap")]
		GraduationCap = 0xf19d,
		///<summary>Alias of: GraduationCap</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.GraduationCap" />
		[IconAlias]
		MortarBoard = GraduationCap,
		///<summary>Yahoo Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/yahoo/" />
		[IconCategory("Brand Icons")]
		[Description("Yahoo Logo")]
		YahooLogo = 0xf19e,
		///<summary>Google Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/google/" />
		[IconCategory("Brand Icons")]
		[Description("Google Logo")]
		GoogleLogo = 0xf1a0,
		///<summary>reddit Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/reddit/" />
		[IconCategory("Brand Icons")]
		[Description("reddit Logo")]
		RedditLogo = 0xf1a1,
		///<summary>reddit Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/reddit-square/" />
		[IconCategory("Brand Icons")]
		[Description("reddit Square")]
		RedditSquare = 0xf1a2,
		///<summary>StumbleUpon Circle (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/stumbleupon-circle/" />
		[IconCategory("Brand Icons")]
		[Description("StumbleUpon Circle")]
		StumbleuponCircle = 0xf1a3,
		///<summary>StumbleUpon Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/stumbleupon/" />
		[IconCategory("Brand Icons")]
		[Description("StumbleUpon Logo")]
		StumbleuponLogo = 0xf1a4,
		///<summary>Delicious Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/delicious/" />
		[IconCategory("Brand Icons")]
		[Description("Delicious Logo")]
		DeliciousLogo = 0xf1a5,
		///<summary>Digg Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/digg/" />
		[IconCategory("Brand Icons")]
		[Description("Digg Logo")]
		DiggLogo = 0xf1a6,
		///<summary>Pied Piper Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/pied-piper/" />
		[IconCategory("Brand Icons")]
		[Description("Pied Piper Logo")]
		PiedPiperLogo = 0xf1a7,
		///<summary>Pied Piper Alternate Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/pied-piper-alt/" />
		[IconCategory("Brand Icons")]
		[Description("Pied Piper Alternate Logo")]
		PiedPiperAlternateLogo = 0xf1a8,
		///<summary>Drupal Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/drupal/" />
		[IconCategory("Brand Icons")]
		[Description("Drupal Logo")]
		DrupalLogo = 0xf1a9,
		///<summary>Joomla Logo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/joomla/" />
		[IconCategory("Brand Icons")]
		[Description("Joomla Logo")]
		JoomlaLogo = 0xf1aa,
		///<summary>Language (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/language/" />
		[IconCategory("Web Application Icons")]
		[Description("Language")]
		Language = 0xf1ab,
		///<summary>Fax (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/fax/" />
		[IconCategory("Web Application Icons")]
		[Description("Fax")]
		Fax = 0xf1ac,
		///<summary>Building (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/building/" />
		[IconCategory("Web Application Icons")]
		[Description("Building")]
		Building = 0xf1ad,
		///<summary>Child (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/child/" />
		[IconCategory("Web Application Icons")]
		[Description("Child")]
		Child = 0xf1ae,
		///<summary>Paw (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/paw/" />
		[IconCategory("Web Application Icons")]
		[Description("Paw")]
		Paw = 0xf1b0,
		///<summary>spoon (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/spoon/" />
		[IconCategory("Web Application Icons")]
		[Description("spoon")]
		Spoon = 0xf1b1,
		///<summary>Cube (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/cube/" />
		[IconCategory("Web Application Icons")]
		[Description("Cube")]
		Cube = 0xf1b2,
		///<summary>Cubes (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/cubes/" />
		[IconCategory("Web Application Icons")]
		[Description("Cubes")]
		Cubes = 0xf1b3,
		///<summary>Behance (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/behance/" />
		[IconCategory("Brand Icons")]
		[Description("Behance")]
		Behance = 0xf1b4,
		///<summary>Behance Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/behance-square/" />
		[IconCategory("Brand Icons")]
		[Description("Behance Square")]
		BehanceSquare = 0xf1b5,
		///<summary>Steam (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/steam/" />
		[IconCategory("Brand Icons")]
		[Description("Steam")]
		Steam = 0xf1b6,
		///<summary>Steam Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/steam-square/" />
		[IconCategory("Brand Icons")]
		[Description("Steam Square")]
		SteamSquare = 0xf1b7,
		///<summary>Recycle (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/recycle/" />
		[IconCategory("Web Application Icons")]
		[Description("Recycle")]
		Recycle = 0xf1b8,
		///<summary>Car (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/car/" />
		[IconCategory("Web Application Icons")]
		[Description("Car")]
		Car = 0xf1b9,
		///<summary>Alias of: Car</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Car" />
		[IconAlias]
		Automobile = Car,
		///<summary>Taxi (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/taxi/" />
		[IconCategory("Web Application Icons")]
		[Description("Taxi")]
		Taxi = 0xf1ba,
		///<summary>Alias of: Taxi</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Taxi" />
		[IconAlias]
		Cab = Taxi,
		///<summary>Tree (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/tree/" />
		[IconCategory("Web Application Icons")]
		[Description("Tree")]
		Tree = 0xf1bb,
		///<summary>Spotify (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/spotify/" />
		[IconCategory("Brand Icons")]
		[Description("Spotify")]
		Spotify = 0xf1bc,
		///<summary>deviantART (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/deviantart/" />
		[IconCategory("Brand Icons")]
		[Description("deviantART")]
		Deviantart = 0xf1bd,
		///<summary>SoundCloud (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/soundcloud/" />
		[IconCategory("Brand Icons")]
		[Description("SoundCloud")]
		Soundcloud = 0xf1be,
		///<summary>Database (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/database/" />
		[IconCategory("Web Application Icons")]
		[Description("Database")]
		Database = 0xf1c0,
		///<summary>PDF File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-pdf-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("PDF File Outlined")]
		PDFFileOutlined = 0xf1c1,
		///<summary>Word File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-word-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Word File Outlined")]
		WordFileOutlined = 0xf1c2,
		///<summary>Excel File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-excel-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Excel File Outlined")]
		ExcelFileOutlined = 0xf1c3,
		///<summary>Powerpoint File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-powerpoint-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Powerpoint File Outlined")]
		PowerpointFileOutlined = 0xf1c4,
		///<summary>Image File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-image-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Image File Outlined")]
		ImageFileOutlined = 0xf1c5,
		///<summary>Alias of: ImageFileOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ImageFileOutlined" />
		[IconAlias]
		FilePhotoO = ImageFileOutlined,
		///<summary>Alias of: ImageFileOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ImageFileOutlined" />
		[IconAlias]
		FilePictureO = ImageFileOutlined,
		///<summary>Archive File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-archive-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Archive File Outlined")]
		ArchiveFileOutlined = 0xf1c6,
		///<summary>Alias of: ArchiveFileOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ArchiveFileOutlined" />
		[IconAlias]
		FileZipO = ArchiveFileOutlined,
		///<summary>Audio File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-audio-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Audio File Outlined")]
		AudioFileOutlined = 0xf1c7,
		///<summary>Alias of: AudioFileOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.AudioFileOutlined" />
		[IconAlias]
		FileSoundO = AudioFileOutlined,
		///<summary>Video File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-video-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Video File Outlined")]
		VideoFileOutlined = 0xf1c8,
		///<summary>Alias of: VideoFileOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.VideoFileOutlined" />
		[IconAlias]
		FileMovieO = VideoFileOutlined,
		///<summary>Code File Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/file-code-o/" />
		[IconCategory("Web Application Icons"),IconCategory("File Type Icons")]
		[Description("Code File Outlined")]
		CodeFileOutlined = 0xf1c9,
		///<summary>Vine (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/vine/" />
		[IconCategory("Brand Icons")]
		[Description("Vine")]
		Vine = 0xf1ca,
		///<summary>Codepen (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/codepen/" />
		[IconCategory("Brand Icons")]
		[Description("Codepen")]
		Codepen = 0xf1cb,
		///<summary>jsFiddle (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/jsfiddle/" />
		[IconCategory("Brand Icons")]
		[Description("jsFiddle")]
		Jsfiddle = 0xf1cc,
		///<summary>Life Ring (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/life-ring/" />
		[IconCategory("Web Application Icons")]
		[Description("Life Ring")]
		LifeRing = 0xf1cd,
		///<summary>Alias of: LifeRing</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
		[IconAlias]
		LifeBouy = LifeRing,
		///<summary>Alias of: LifeRing</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
		[IconAlias]
		LifeBuoy = LifeRing,
		///<summary>Alias of: LifeRing</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
		[IconAlias]
		LifeSaver = LifeRing,
		///<summary>Alias of: LifeRing</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
		[IconAlias]
		Support = LifeRing,
		///<summary>Circle Outlined Notched (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/circle-o-notch/" />
		[IconCategory("Web Application Icons"),IconCategory("Spinner Icons")]
		[Description("Circle Outlined Notched")]
		CircleOutlinedNotched = 0xf1ce,
		///<summary>Rebel Alliance (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/rebel/" />
		[IconCategory("Brand Icons")]
		[Description("Rebel Alliance")]
		RebelAlliance = 0xf1d0,
		///<summary>Alias of: RebelAlliance</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.RebelAlliance" />
		[IconAlias]
		Ra = RebelAlliance,
		///<summary>Galactic Empire (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/empire/" />
		[IconCategory("Brand Icons")]
		[Description("Galactic Empire")]
		GalacticEmpire = 0xf1d1,
		///<summary>Alias of: GalacticEmpire</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.GalacticEmpire" />
		[IconAlias]
		Ge = GalacticEmpire,
		///<summary>Git Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/git-square/" />
		[IconCategory("Brand Icons")]
		[Description("Git Square")]
		GitSquare = 0xf1d2,
		///<summary>Git (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/git/" />
		[IconCategory("Brand Icons")]
		[Description("Git")]
		Git = 0xf1d3,
		///<summary>Hacker News (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/hacker-news/" />
		[IconCategory("Brand Icons")]
		[Description("Hacker News")]
		HackerNews = 0xf1d4,
		///<summary>Tencent Weibo (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/tencent-weibo/" />
		[IconCategory("Brand Icons")]
		[Description("Tencent Weibo")]
		TencentWeibo = 0xf1d5,
		///<summary>QQ (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/qq/" />
		[IconCategory("Brand Icons")]
		[Description("QQ")]
		QQ = 0xf1d6,
		///<summary>Weixin (WeChat) (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/weixin/" />
		[IconCategory("Brand Icons")]
		[Description("Weixin (WeChat)")]
		Weixin = 0xf1d7,
		///<summary>Alias of: Weixin</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Weixin" />
		[IconAlias]
		Wechat = Weixin,
		///<summary>Paper Plane (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/paper-plane/" />
		[IconCategory("Web Application Icons")]
		[Description("Paper Plane")]
		PaperPlane = 0xf1d8,
		///<summary>Alias of: PaperPlane</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PaperPlane" />
		[IconAlias]
		Send = PaperPlane,
		///<summary>Paper Plane Outlined (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/paper-plane-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Paper Plane Outlined")]
		PaperPlaneOutlined = 0xf1d9,
		///<summary>Alias of: PaperPlaneOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PaperPlaneOutlined" />
		[IconAlias]
		SendO = PaperPlaneOutlined,
		///<summary>History (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/history/" />
		[IconCategory("Web Application Icons")]
		[Description("History")]
		History = 0xf1da,
		///<summary>Circle Outlined Thin (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/circle-thin/" />
		[IconCategory("Web Application Icons")]
		[Description("Circle Outlined Thin")]
		CircleOutlinedThin = 0xf1db,
		///<summary>header (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/header/" />
		[IconCategory("Text Editor Icons")]
		[Description("header")]
		Header = 0xf1dc,
		///<summary>paragraph (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/paragraph/" />
		[IconCategory("Text Editor Icons")]
		[Description("paragraph")]
		Paragraph = 0xf1dd,
		///<summary>Sliders (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/sliders/" />
		[IconCategory("Web Application Icons")]
		[Description("Sliders")]
		Sliders = 0xf1de,
		///<summary>Share Alt (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/share-alt/" />
		[IconCategory("Web Application Icons"),IconCategory("Brand Icons")]
		[Description("Share Alt")]
		ShareAlt = 0xf1e0,
		///<summary>Share Alt Square (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/share-alt-square/" />
		[IconCategory("Web Application Icons"),IconCategory("Brand Icons")]
		[Description("Share Alt Square")]
		ShareAltSquare = 0xf1e1,
		///<summary>Bomb (created: 4.1)</summary>
		///<see cref="http://fontawesome.io/icon/bomb/" />
		[IconCategory("Web Application Icons")]
		[Description("Bomb")]
		Bomb = 0xf1e2,
		///<summary>Futbol Outlined (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/futbol-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Futbol Outlined")]
		FutbolOutlined = 0xf1e3,
		///<summary>Alias of: FutbolOutlined</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FutbolOutlined" />
		[IconAlias]
		SoccerBallO = FutbolOutlined,
		///<summary>TTY (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/tty/" />
		[IconCategory("Web Application Icons")]
		[Description("TTY")]
		TTY = 0xf1e4,
		///<summary>Binoculars (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/binoculars/" />
		[IconCategory("Web Application Icons")]
		[Description("Binoculars")]
		Binoculars = 0xf1e5,
		///<summary>Plug (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/plug/" />
		[IconCategory("Web Application Icons")]
		[Description("Plug")]
		Plug = 0xf1e6,
		///<summary>Slideshare (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/slideshare/" />
		[IconCategory("Brand Icons")]
		[Description("Slideshare")]
		Slideshare = 0xf1e7,
		///<summary>Twitch (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/twitch/" />
		[IconCategory("Brand Icons")]
		[Description("Twitch")]
		Twitch = 0xf1e8,
		///<summary>Yelp (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/yelp/" />
		[IconCategory("Brand Icons")]
		[Description("Yelp")]
		Yelp = 0xf1e9,
		///<summary>Newspaper Outlined (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/newspaper-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Newspaper Outlined")]
		NewspaperOutlined = 0xf1ea,
		///<summary>WiFi (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/wifi/" />
		[IconCategory("Web Application Icons")]
		[Description("WiFi")]
		Wifi = 0xf1eb,
		///<summary>Calculator (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/calculator/" />
		[IconCategory("Web Application Icons")]
		[Description("Calculator")]
		Calculator = 0xf1ec,
		///<summary>Paypal (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/paypal/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Paypal")]
		Paypal = 0xf1ed,
		///<summary>Goole Wallet (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/google-wallet/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Goole Wallet")]
		GooleWallet = 0xf1ee,
		///<summary>Visa Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-visa/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Visa Credit Card")]
		VisaCreditCard = 0xf1f0,
		///<summary>MasterCard Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-mastercard/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("MasterCard Credit Card")]
		MastercardCreditCard = 0xf1f1,
		///<summary>Discover Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-discover/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Discover Credit Card")]
		DiscoverCreditCard = 0xf1f2,
		///<summary>American Express Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-amex/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("American Express Credit Card")]
		AmericanExpressCreditCard = 0xf1f3,
		///<summary>Paypal Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-paypal/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Paypal Credit Card")]
		PaypalCreditCard = 0xf1f4,
		///<summary>Stripe Credit Card (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc-stripe/" />
		[IconCategory("Brand Icons"),IconCategory("Payment Icons")]
		[Description("Stripe Credit Card")]
		StripeCreditCard = 0xf1f5,
		///<summary>Bell Slash (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/bell-slash/" />
		[IconCategory("Web Application Icons")]
		[Description("Bell Slash")]
		BellSlash = 0xf1f6,
		///<summary>Bell Slash Outlined (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/bell-slash-o/" />
		[IconCategory("Web Application Icons")]
		[Description("Bell Slash Outlined")]
		BellSlashOutlined = 0xf1f7,
		///<summary>Trash (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/trash/" />
		[IconCategory("Web Application Icons")]
		[Description("Trash")]
		Trash = 0xf1f8,
		///<summary>Copyright (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/copyright/" />
		[IconCategory("Web Application Icons")]
		[Description("Copyright")]
		Copyright = 0xf1f9,
		///<summary>At (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/at/" />
		[IconCategory("Web Application Icons")]
		[Description("At")]
		At = 0xf1fa,
		///<summary>Eyedropper (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/eyedropper/" />
		[IconCategory("Web Application Icons")]
		[Description("Eyedropper")]
		Eyedropper = 0xf1fb,
		///<summary>Paint Brush (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/paint-brush/" />
		[IconCategory("Web Application Icons")]
		[Description("Paint Brush")]
		PaintBrush = 0xf1fc,
		///<summary>Birthday Cake (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/birthday-cake/" />
		[IconCategory("Web Application Icons")]
		[Description("Birthday Cake")]
		BirthdayCake = 0xf1fd,
		///<summary>Area Chart (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/area-chart/" />
		[IconCategory("Web Application Icons"),IconCategory("Chart Icons")]
		[Description("Area Chart")]
		AreaChart = 0xf1fe,
		///<summary>Pie Chart (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/pie-chart/" />
		[IconCategory("Web Application Icons"),IconCategory("Chart Icons")]
		[Description("Pie Chart")]
		PieChart = 0xf200,
		///<summary>Line Chart (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/line-chart/" />
		[IconCategory("Web Application Icons"),IconCategory("Chart Icons")]
		[Description("Line Chart")]
		LineChart = 0xf201,
		///<summary>last.fm (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/lastfm/" />
		[IconCategory("Brand Icons")]
		[Description("last.fm")]
		LastFm = 0xf202,
		///<summary>last.fm Square (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/lastfm-square/" />
		[IconCategory("Brand Icons")]
		[Description("last.fm Square")]
		LastFmSquare = 0xf203,
		///<summary>Toggle Off (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/toggle-off/" />
		[IconCategory("Web Application Icons")]
		[Description("Toggle Off")]
		ToggleOff = 0xf204,
		///<summary>Toggle On (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/toggle-on/" />
		[IconCategory("Web Application Icons")]
		[Description("Toggle On")]
		ToggleOn = 0xf205,
		///<summary>Bicycle (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/bicycle/" />
		[IconCategory("Web Application Icons")]
		[Description("Bicycle")]
		Bicycle = 0xf206,
		///<summary>Bus (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/bus/" />
		[IconCategory("Web Application Icons")]
		[Description("Bus")]
		Bus = 0xf207,
		///<summary>ioxhost (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/ioxhost/" />
		[IconCategory("Brand Icons")]
		[Description("ioxhost")]
		Ioxhost = 0xf208,
		///<summary>AngelList (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/angellist/" />
		[IconCategory("Brand Icons")]
		[Description("AngelList")]
		Angellist = 0xf209,
		///<summary>Closed Captions (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/cc/" />
		[IconCategory("Web Application Icons")]
		[Description("Closed Captions")]
		ClosedCaptions = 0xf20a,
		///<summary>Shekel (ILS) (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/ils/" />
		[IconCategory("Currency Icons")]
		[Description("Shekel (ILS)")]
		Shekel = 0xf20b,
		///<summary>Alias of: Shekel</summary>
		///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Shekel" />
		[IconAlias]
		Sheqel = Shekel,
		///<summary>meanpath (created: 4.2)</summary>
		///<see cref="http://fontawesome.io/icon/meanpath/" />
		[IconCategory("Brand Icons")]
		[Description("meanpath")]
		Meanpath = 0xf20c,
	}
}
