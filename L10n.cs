﻿using ColossalFramework.Globalization;

namespace LoadingScreenMod
{
    public static class L10n
    {
        public const int FAILED = 0;
        public const int MISSING = 1;
        public const int DUPLICATE = 2;
        public const int DUPLICATES = 3;
        public const int SCENES_AND_ASSETS = 4;
        public const int MAIN = 5;
        public const int SIMULATION = 6;
        public const int ASSETS_LOADER = 7;
        public const int NEW_LOADING_OPTIONS = 8;
        public const int MAJOR_GAME_UPDATE = 9;
        public const int ASSETS_REPORT = 10;
        public const int ASSETS_REPORT_FOR_CS = 11;
        public const int TO_STOP_SAVING = 12;
        public const int ASSETS_THAT_FAILED = 13;
        public const int NO_FAILED_ASSETS = 14;
        public const int ASSET_ERRORS = 15;
        public const int NO_ERRORS_FOUND = 16;
        public const int ASSET_WARNINGS = 17;
        public const int NO_WARNINGS = 18;
        public const int ASSETS_THAT_ARE_MISSING = 19;
        public const int SECTION_MIGHT_BE_INCOMPLETE = 20;
        public const int PLACED_BUT_MISSING = 21;
        public const int NO_MISSING_ASSETS = 22;
        public const int TO_TRACK_MISSING = 23;
        public const int DUPLICATE_NAMES = 24;
        public const int THESE_ARE_USED = 25;
        public const int NO_USED_ASSETS = 26;
        public const int THESE_ARE_UNNECESSARY = 27;
        public const int ENABLED_BUT_UNNECESSARY = 28;
        public const int NO_UNNECESSARY_ASSETS = 29;
        public const int TO_TRACK_USED = 30;
        public const int LOADING_STATS = 31;
        public const int PERFORMANCE = 32;
        public const int CUSTOM_ASSETS_LOADED = 33;
        public const int ASSETS = 34;
        public const int LOADING_SPEED = 35;
        public const int ASSETS_PER_SECOND = 36;
        public const int ASSETS_LOADING_TIME = 37;
        public const int MINUTES_SECONDS = 38;
        public const int TOTAL_LOADING_TIME = 39;
        public const int PEAK_MEMORY_USAGE = 40;
        public const int VIRTUAL_MEMORY = 41;
        public const int SHARING_OF_RESOURCES = 42;
        public const int TEXTURES = 43;
        public const int TIMES = 44;
        public const int MATERIALS = 45;
        public const int MESHES = 46;
        public const int SKIPPED_PREFABS = 47;
        public const int BUILDING_PREFABS = 48;
        public const int VEHICLE_PREFABS = 49;
        public const int PROP_PREFABS = 50;
        public const int ASSETS_BROWSER = 51;
        public const int ASSET_BUGS = 52;
        public const int ASSET_BUG = 53;
        public const int ASSET_USES_PRIVATE_ASSET = 54;
        public const int NO_LINK_IS_AVAILABLE = 55;
        public const int IS_POSSIBLY_DLC = 56;
        public const int SAME_ASSET_NAME = 57;
        public const int IN_ALL_OF_THESE = 58;
        public const int NO_DUPLICATES = 59;
        public const int PROBLEMS_WERE_DETECTED = 60;
        public const int INVALID_LOD_TEXTURE_SIZE = 61;
        public const int ASSET_NAMING_CONFLICT = 62;
        public const int OBSERVATIONS_WERE_MADE = 63;
        public const int VERY_LARGE_LOD_TEXTURE = 64;
        public const int YOU_HAVE = 65;
        public const int DOES_NOT_CONTAIN = 66;
        public const int NAME_PROBABLY_CHANGED = 67;
        public const int BY_THE_AUTHOR = 68;
        public const int VERY_LARGE_LOD_MESH = 69;
        public const int BUILDINGS_AND_PARKS = 70;
        public const int PROPS = 71;
        public const int TREES = 72;
        public const int VEHICLES = 73;
        public const int CITIZENS = 74;
        public const int NETS = 75;
        public const int NETS_IN_BUILDINGS = 76;
        public const int PROPS_IN_BUILDINGS = 77;
        public const int TREES_IN_BUILDINGS = 78;
        public const int AS_YOU_KNOW = 79;
        public const int USING_THIS_FILE = 80;
        public const int THESE_ARE_NOT_REPORTED = 81;
        public const int LSM_REPORTED_THESE = 82;
        public const int REPORTED_MISSING = 83;
        public const int REPORTED_DUPLICATE = 84;
        public const int GO_AHEAD = 85;
        public const int INCOMPATIBLE_VERSION = 86;
        public const int LOADING_OPTIONS_FOR_ASSETS = 87;
        public const int CUSTOM_MEANS = 88;
        public const int LOAD_ENABLED_ASSETS = 89;
        public const int LOAD_ENABLED_IN_CM = 90;
        public const int LOAD_USED_ASSETS = 91;
        public const int LOAD_USED_IN_YOUR_CITY = 92;
        public const int SHARE_TEXTURES = 93;
        public const int REPLACE_DUPLICATES = 94;
        public const int SHARE_MATERIALS = 95;
        public const int SHARE_MESHES = 96;
        public const int OPTIMIZE_THUMBNAILS = 97;
        public const int OPTIMIZE_TEXTURES = 98;
        public const int REPORTING = 99;
        public const int SAVE_REPORTS_IN_DIRECTORY = 100;
        public const int SAVE_REPORTS_OF_ASSETS = 101;
        public const int CHECK_FOR_ERRORS = 102;
        public const int DO_NOT_REPORT_THESE = 103;
        public const int OPEN_FILE = 104;
        public const int CLICK_TO_OPEN = 105;
        public const int PREFAB_SKIPPING = 106;
        public const int PREFAB_MEANS = 107;
        public const int SKIP_THESE = 108;
        public const int SAFE_MODE = 109;
        public const int AUTOMATICALLY_DISABLED = 110;
        public const int REMOVE_VEHICLE_AGENTS = 111;
        public const int REMOVE_CITIZEN_AGENTS = 112;
        public const int TRY_TO_RECOVER = 113;
        public const int THEN_ORDER_BY = 114;
        public const int WORKSHOP_ITEM = 115;
        public const int USED_BY = 116;
        public const int ORDER_BY = 117;
        public const int FIND_ASSETS = 118;
        public const int TRIANGLES = 119;
        public const int VERTICES = 120;
        public const int LONG_NAME = 121;
        public const int CUSTOM_ASSETS = 122;
        public const int ENABLING_AND_DISABLING = 123;
        public const int EXTREMELY_LARGE_LOD_MESH = 124;
        public const int PER_SECOND = 125;
        public const int UNKNOWN = 126;

        static readonly string[] en =
        {
            @"failed", // FAILED = 0
            @"missing", // MISSING = 1
            @"duplicate", // DUPLICATE = 2
            @"duplicates", // DUPLICATES = 3
            @"Scenes and Assets:", // SCENES_AND_ASSETS = 4
            @"Main:", // MAIN = 5
            @"Simulation:", // SIMULATION = 6
            @"Assets Loader:", // ASSETS_LOADER = 7
            @"New loading options", // NEW_LOADING_OPTIONS = 8
            @"Major game update detected. Mod is now inactive.", // MAJOR_GAME_UPDATE = 9
            @"Assets Report", // ASSETS_REPORT = 10
            @"Assets report for Cities: Skylines.", // ASSETS_REPORT_FOR_CS = 11
            @"To stop saving these files, disable the option ""Save assets report"" in Loading Screen Mod.", // TO_STOP_SAVING = 12
            @"Assets that failed to load", // ASSETS_THAT_FAILED = 13
            @"No failed assets.", // NO_FAILED_ASSETS = 14
            @"Asset errors", // ASSET_ERRORS = 15
            @"No errors found.", // NO_ERRORS_FOUND = 16
            @"Asset warnings", // ASSET_WARNINGS = 17
            @"No warnings.", // NO_WARNINGS = 18
            @"Assets that are missing", // ASSETS_THAT_ARE_MISSING = 19
            @"Note: this section might be incomplete because some assets are not reported.", // SECTION_MIGHT_BE_INCOMPLETE = 20
            @"There are two reasons for an asset to appear in this section: (1) The asset is placed in the city but is missing (2) The asset is used by some other asset but is missing.", // PLACED_BUT_MISSING = 21
            @"No missing assets.", // NO_MISSING_ASSETS = 22
            @"To track missing assets, enable the option ""Load used assets"".", // TO_TRACK_MISSING = 23
            @"Duplicate asset names", // DUPLICATE_NAMES = 24
            @"The following custom assets are used in this city", // THESE_ARE_USED = 25
            @"No used assets.", // NO_USED_ASSETS = 26
            @"The following enabled assets are currently unnecessary (not used in this city)", // THESE_ARE_UNNECESSARY = 27
            @"There are two reasons for an asset to appear in this section: (1) The asset is enabled but unnecessary (2) The asset is included in an enabled district style but is unnecessary.", // ENABLED_BUT_UNNECESSARY = 28
            @"No unnecessary assets.", // NO_UNNECESSARY_ASSETS = 29
            @"To track used assets, enable the option ""Load used assets"".", // TO_TRACK_USED = 30
            @"Loading stats", // LOADING_STATS = 31
            @"Performance", // PERFORMANCE = 32
            @"Custom assets loaded", // CUSTOM_ASSETS_LOADED = 33
            @"assets", // ASSETS = 34
            @"Loading speed", // LOADING_SPEED = 35
            @"assets / second", // ASSETS_PER_SECOND = 36
            @"Custom assets loading time", // ASSETS_LOADING_TIME = 37
            @"minutes:seconds", // MINUTES_SECONDS = 38
            @"Total loading time", // TOTAL_LOADING_TIME = 39
            @"Peak memory usage", // PEAK_MEMORY_USAGE = 40
            @"Virtual memory", // VIRTUAL_MEMORY = 41
            @"Sharing of custom asset resources", // SHARING_OF_RESOURCES = 42
            @"Textures", // TEXTURES = 43
            @"times", // TIMES = 44
            @"Materials", // MATERIALS = 45
            @"Meshes", // MESHES = 46
            @"Skipped prefabs", // SKIPPED_PREFABS = 47
            @"Building prefabs", // BUILDING_PREFABS = 48
            @"Vehicle prefabs", // VEHICLE_PREFABS = 49
            @"Prop prefabs", // PROP_PREFABS = 50
            @"Assets Browser", // ASSETS_BROWSER = 51
            @"Asset bugs", // ASSET_BUGS = 52
            @"Asset bug", // ASSET_BUG = 53
            @"Workshop asset uses private asset", // ASSET_USES_PRIVATE_ASSET = 54
            @"is probably a workshop prop or tree but no link is available.", // NO_LINK_IS_AVAILABLE = 55
            @"is possibly DLC or mod content.", // IS_POSSIBLY_DLC = 56
            @"Same asset name", // SAME_ASSET_NAME = 57
            @"in all of these", // IN_ALL_OF_THESE = 58
            @"No duplicates.", // NO_DUPLICATES = 59
            @"Problems were detected in these assets.", // PROBLEMS_WERE_DETECTED = 60
            @"Invalid LOD texture size", // INVALID_LOD_TEXTURE_SIZE = 61
            @"Asset naming conflict", // ASSET_NAMING_CONFLICT = 62
            @"Warnings were raised about these assets.", // OBSERVATIONS_WERE_MADE = 63
            @"Very large LOD texture", // VERY_LARGE_LOD_TEXTURE = 64
            @"You have", // YOU_HAVE = 65
            @"but it does not contain", // DOES_NOT_CONTAIN = 66
            @"Name probably changed", // NAME_PROBABLY_CHANGED = 67
            @"by the asset author.", // BY_THE_AUTHOR = 68
            @"Very large LOD mesh", // VERY_LARGE_LOD_MESH = 69
            @"Buildings and parks", // BUILDINGS_AND_PARKS = 70
            @"Props", // PROPS = 71
            @"Trees", // TREES = 72
            @"Vehicles", // VEHICLES = 73
            @"Citizens", // CITIZENS = 74
            @"Nets", // NETS = 75
            @"Nets in buildings and parks", // NETS_IN_BUILDINGS = 76
            @"Props in buildings, parks and nets", // PROPS_IN_BUILDINGS = 77
            @"Trees in buildings, parks and nets", // TREES_IN_BUILDINGS = 78
            @"#As you know, LSM reports missing and duplicate assets on the loading screen and in the Assets report.", // AS_YOU_KNOW = 79
            @"#Using this file, you can stop reporting some assets if you want.", // USING_THIS_FILE = 80
            @"#These assets are not reported. To report an asset again, put its hashtag back or remove the line.", // THESE_ARE_NOT_REPORTED = 81
            @"#LSM reported these assets. To stop reporting them, just remove the hashtags.", // LSM_REPORTED_THESE = 82
            @"#Reported missing.", // REPORTED_MISSING = 83
            @"#Reported duplicate.", // REPORTED_DUPLICATE = 84
            @"#Go ahead and load a savegame that has some missing assets, then open this file again.", // GO_AHEAD = 85
            @"Mod version is incompatible with the game version", // INCOMPATIBLE_VERSION = 86
            @"Loading options for custom assets", // LOADING_OPTIONS_FOR_ASSETS = 87
            @"Custom means workshop assets and assets created by yourself", // CUSTOM_MEANS = 88
            @"Load enabled assets", // LOAD_ENABLED_ASSETS = 89
            @"Load the assets enabled in Content Manager", // LOAD_ENABLED_IN_CM = 90
            @"Load used assets", // LOAD_USED_ASSETS = 91
            @"Load the assets that are used in your city", // LOAD_USED_IN_YOUR_CITY = 92
            @"Share textures", // SHARE_TEXTURES = 93
            @"Replace exact duplicates by references", // REPLACE_DUPLICATES = 94
            @"Share materials", // SHARE_MATERIALS = 95
            @"Share meshes", // SHARE_MESHES = 96
            @"Optimize thumbnails", // OPTIMIZE_THUMBNAILS = 97
            @"Optimize asset thumb and tooltip textures", // OPTIMIZE_TEXTURES = 98
            @"Reporting", // REPORTING = 99
            @"Save reports in this directory:", // SAVE_REPORTS_IN_DIRECTORY = 100
            @"Save reports of missing, failed and used assets", // SAVE_REPORTS_OF_ASSETS = 101
            @"Check assets for errors", // CHECK_FOR_ERRORS = 102
            @"Do not report these custom assets as missing or duplicate:", // DO_NOT_REPORT_THESE = 103
            @"Open text file", // OPEN_FILE = 104
            @"Click to open", // CLICK_TO_OPEN = 105
            @"Prefab skipping", // PREFAB_SKIPPING = 106
            @"Prefab means the built-in assets in the game", // PREFAB_MEANS = 107
            @"Skip the prefabs named in this file:", // SKIP_THESE = 108
            @"Load next save in Safe Mode", // SAFE_MODE = 109
            @"These options are automatically disabled when you exit to desktop", // AUTOMATICALLY_DISABLED = 110
            @"Remove all vehicle agents", // REMOVE_VEHICLE_AGENTS = 111
            @"Remove all citizen agents", // REMOVE_CITIZEN_AGENTS = 112
            @"Try to recover from Simulation Errors", // TRY_TO_RECOVER = 113
            @"then order by", // THEN_ORDER_BY = 114
            @"Workshop item", // WORKSHOP_ITEM = 115
            @"Used by", // USED_BY = 116
            @"Order by", // ORDER_BY = 117
            @"Find assets", // FIND_ASSETS = 118
            @"triangles", // TRIANGLES = 119
            @"vertices", // VERTICES = 120
            @"<long name>", // LONG_NAME = 121
            @"Custom Assets", // CUSTOM_ASSETS = 122
            @"Enabling and disabling assets", // ENABLING_AND_DISABLING = 123
            @"Extremely large LOD mesh", // EXTREMELY_LARGE_LOD_MESH = 124
            @" / sec", // PER_SECOND = 125
            @"Unknown" // UNKNOWN = 126
        };

        static readonly string[] zh =
        {
            @"失败", // FAILED = 0
            @"丢失", // MISSING = 1
            @"重复项", // DUPLICATE = 2
            @"重复项", // DUPLICATES = 3
            @"场景与资产", // SCENES_AND_ASSETS = 4
            @"主要", // MAIN = 5
            @"模拟", // SIMULATION = 6
            @"资产加载器", // ASSETS_LOADER = 7
            @"新的加载选项", // NEW_LOADING_OPTIONS = 8
            @"检测到主要游戏更新，MOD现已停用", // MAJOR_GAME_UPDATE = 9
            @"资产报告", // ASSETS_REPORT = 10
            @"城市资产报告：天际线", // ASSETS_REPORT_FOR_CS = 11
            @"要停止保存这些文件，请在游戏设置中的载入画面MOD选项中禁用", // TO_STOP_SAVING = 12
            @"无法加载的资产", // ASSETS_THAT_FAILED = 13
            @"没有失败的资产", // NO_FAILED_ASSETS = 14
            @"资产错误", // ASSET_ERRORS = 15
            @"找不到错误", // NO_ERRORS_FOUND = 16
            @"资产警告", // ASSET_WARNINGS = 17
            @"没有警告", // NO_WARNINGS = 18
            @"丢失的资产", // ASSETS_THAT_ARE_MISSING = 19
            @"注意：此部分可能不完整，因为某些资产为报告", // SECTION_MIGHT_BE_INCOMPLETE = 20
            @"此部分中显示资产的原因有两种：（1）该资产放置在城市中但丢失了.（2）该资产被其他某些资产使用但丢失了.", // PLACED_BUT_MISSING = 21
            @"没有丢失资产", // NO_MISSING_ASSETS = 22
            @"要跟踪丢失的资产，请启用该选项 ""加载使用的资产""", // TO_TRACK_MISSING = 23
            @"资产名称重复", // DUPLICATE_NAMES = 24
            @"该城市使用以下自定义资产", // THESE_ARE_USED = 25
            @"无重复资产", // NO_USED_ASSETS = 26
            @"当前不需要以下已启用资产（城市中未使用）", // THESE_ARE_UNNECESSARY = 27
            @"此部分中显示资产的原因有两种：（1）资产已启用但不是必需的（2）资产包含在已启用的分区样式中但不是必需的.", // ENABLED_BUT_UNNECESSARY = 28
            @"没有不必要的资产", // NO_UNNECESSARY_ASSETS = 29
            @"要跟踪已用的资产，请启用该选项 ""加载使用的资产""", // TO_TRACK_USED = 30
            @"加载统计", // LOADING_STATS = 31
            @"性能", // PERFORMANCE = 32
            @"已加载自定义资产", // CUSTOM_ASSETS_LOADED = 33
            @"资产", // ASSETS = 34
            @"加载速度", // LOADING_SPEED = 35
            @"资产/秒", // ASSETS_PER_SECOND = 36
            @"自定义加载时间", // ASSETS_LOADING_TIME = 37
            @"分钟：秒", // MINUTES_SECONDS = 38
            @"总加载时间", // TOTAL_LOADING_TIME = 39
            @"内存使用峰值", // PEAK_MEMORY_USAGE = 40
            @"虚拟内存", // VIRTUAL_MEMORY = 41
            @"共享自定义资产", // SHARING_OF_RESOURCES = 42
            @"贴图", // TEXTURES = 43
            @"次", // TIMES = 44
            @"材料", // MATERIALS = 45
            @"网格", // MESHES = 46
            @"跳过预制资产", // SKIPPED_PREFABS = 47
            @"建筑预制资产", // BUILDING_PREFABS = 48
            @"车辆预制资产", // VEHICLE_PREFABS = 49
            @"道具预制资产", // PROP_PREFABS = 50
            @"资产浏览器", // ASSETS_BROWSER = 51
            @"资产错误", // ASSET_BUGS = 52
            @"资产错误", // ASSET_BUG = 53
            @"作者可能使用了私有资产", // ASSET_USES_PRIVATE_ASSET = 54
            @"可能是一个道具或树，但是没有可用链接", // NO_LINK_IS_AVAILABLE = 55
            @"可能是DLC或Mod内容", // IS_POSSIBLY_DLC = 56
            @"在这些资产中", // SAME_ASSET_NAME = 57
            @"都使用了相同的资产名称", // IN_ALL_OF_THESE = 58
            @"没有重复", // NO_DUPLICATES = 59
            @"在这些资产中发现问题", // PROBLEMS_WERE_DETECTED = 60
            @"无效的LOD纹理大小", // INVALID_LOD_TEXTURE_SIZE = 61
            @"资产名称冲突", // ASSET_NAMING_CONFLICT = 62
            @"对这些资产进行了观察", // OBSERVATIONS_WERE_MADE = 63
            @"非常大的LOD纹理", // VERY_LARGE_LOD_TEXTURE = 64
            @"你有", // YOU_HAVE = 65
            @"但它不包含", // DOES_NOT_CONTAIN = 66
            @"资产作者可能更改了", // NAME_PROBABLY_CHANGED = 67
            @"名称.", // BY_THE_AUTHOR = 68
            @"非常大的LOD网格", // VERY_LARGE_LOD_MESH = 69
            @"建筑物和公园", // BUILDINGS_AND_PARKS = 70
            @"道具", // PROPS = 71
            @"树木", // TREES = 72
            @"载具", // VEHICLES = 73
            @"市民", // CITIZENS = 74
            @"道路", // NETS = 75
            @"建筑物和公园网格模型", // NETS_IN_BUILDINGS = 76
            @"建筑物、公园和道路的支柱", // PROPS_IN_BUILDINGS = 77
            @"建筑物、公园和道路的树木", // TREES_IN_BUILDINGS = 78
            @"#如您所知，LSM报告在加载屏幕和资产报告中丢失和重复的资产", // AS_YOU_KNOW = 79
            @"#如果您愿意，可以使用此文件停止报告某些资产", // USING_THIS_FILE = 80
            @"#这些资产没有报告.要再次报告资产，请将其标签放回或删除行", // THESE_ARE_NOT_REPORTED = 81
            @"#LSM报告了这些资产。要停止报告，只需删除标签", // LSM_REPORTED_THESE = 82
            @"#丢失资产", // REPORTED_MISSING = 83
            @"#重复资产", // REPORTED_DUPLICATE = 84
            @"#首先加载具有一些缺少资产的存档或新开存档，然后再次打开此文件", // GO_AHEAD = 85
            @"检测到主要游戏更新. Mod现已停用", // INCOMPATIBLE_VERSION = 86
            @"加载自定义资产选项", // LOADING_OPTIONS_FOR_ASSETS = 87
            @"自定义是指工坊资产和您自己创建的资产", // CUSTOM_MEANS = 88
            @"加载启用的资产", // LOAD_ENABLED_ASSETS = 89
            @"加载内容管理器中的资产", // LOAD_ENABLED_IN_CM = 90
            @"加载使用的资产", // LOAD_USED_ASSETS = 91
            @"加载您所在城市使用的资产", // LOAD_USED_IN_YOUR_CITY = 92
            @"共享贴图", // SHARE_TEXTURES = 93
            @"用引用替换完全重复的", // REPLACE_DUPLICATES = 94
            @"共享材质", // SHARE_MATERIALS = 95
            @"共享模型", // SHARE_MESHES = 96
            @"优化缩略图", // OPTIMIZE_THUMBNAILS = 97
            @"优化资源和工具提示纹理", // OPTIMIZE_TEXTURES = 98
            @"统计报告", // REPORTING = 99
            @"在此目录中保存报表（可手动更改目录）:", // SAVE_REPORTS_IN_DIRECTORY = 100
            @"保存丢失、失败和使用过的资产的报告", // SAVE_REPORTS_OF_ASSETS = 101
            @"检查资产是否错误", // CHECK_FOR_ERRORS = 102
            @"隐藏下面文本文件中的自定义资产丢失或重复报告:", // DO_NOT_REPORT_THESE = 103
            @"打开文本文件", // OPEN_FILE = 104
            @"点击打开", // CLICK_TO_OPEN = 105
            @"跳过预制资产", // PREFAB_SKIPPING = 106
            @"预制资产至游戏中的内置资产", // PREFAB_MEANS = 107
            @"跳过此文件中命名的预制资产（可手动更改目录）:", // SKIP_THESE = 108
            @"在安全模式下加载保存", // SAFE_MODE = 109
            @"当您退出桌面时，选项会自动禁用", // AUTOMATICALLY_DISABLED = 110
            @"删除所有车辆主题", // REMOVE_VEHICLE_AGENTS = 111
            @"删除所有市民主题", // REMOVE_CITIZEN_AGENTS = 112
            @"尝试从模拟错误中恢复", // TRY_TO_RECOVER = 113
            @"再排序", // THEN_ORDER_BY = 114
            @"工坊资产", // WORKSHOP_ITEM = 115
            @"使用者", // USED_BY = 116
            @"排序", // ORDER_BY = 117
            @"找", // FIND_ASSETS = 118
            @"三角形", // TRIANGLES = 119
            @"顶点", // VERTICES = 120
            @"<长资产名称>", // LONG_NAME = 121
            @"自定义资产", // CUSTOM_ASSETS = 122
            @"启用和禁用资产", // ENABLING_AND_DISABLING = 123
            @"非常大的LOD网格", // EXTREMELY_LARGE_LOD_MESH = 124
            @" 资产/秒", // PER_SECOND = 125
            @"未知" // UNKNOWN = 126
        };
		
		static readonly string[] ko =
        {
            @"실패함", // FAILED = 0
            @"사라짐", // MISSING = 1
            @"중복", // DUPLICATE = 2
            @"중복들", // DUPLICATES = 3
            @"장면과 에셋들:", // SCENES_AND_ASSETS = 4
            @"불러오는중:", // MAIN = 5
            @"문제발생:", // SIMULATION = 6
            @"에셋 로더:", // ASSETS_LOADER = 7
            @"새로운 로딩 옵션", // NEW_LOADING_OPTIONS = 8
            @"게임 주요 업데이트 감지됨. 모드 비활성화됨.", // MAJOR_GAME_UPDATE = 9
            @"에셋 보고서", // ASSETS_REPORT = 10
            @"시티즈 스카이라인을 위한 에셋 보고서.", // ASSETS_REPORT_FOR_CS = 11
            @"해당 파일을 그만 저장하려면, Loading Screen Mod 설정에서 ""에셋 에러 점검""을 비활성화 하십시오.", // TO_STOP_SAVING = 12
            @"에셋 로딩 실패", // ASSETS_THAT_FAILED = 13
            @"로딩 안 된 에셋 없음.", // NO_FAILED_ASSETS = 14
            @"에셋 에러", // ASSET_ERRORS = 15
            @"발견된 에러 없음.", // NO_ERRORS_FOUND = 16
            @"에셋 경고", // ASSET_WARNINGS = 17
            @"경고 없음.", // NO_WARNINGS = 18
            @"사라진 에셋들", // ASSETS_THAT_ARE_MISSING = 19
            @"참고 : 해당 섹션은 보고되지 않은 일부 자산으로 인하여 정확하지 않을 수 있습니다.", // SECTION_MIGHT_BE_INCOMPLETE = 20
            @"해당 섹션에 이 에셋이 문제로 야기되는 두가지 이유 : (1) 해당 에셋이 도시에 있었지만 사라짐 (2) 해당 에셋이 다른에셋에 사용되었으나 사라짐.", // PLACED_BUT_MISSING = 21
            @"사라진 에셋 없음.", // NO_MISSING_ASSETS = 22
            @"사라진 에셋을 추적하려면, ""사용된 에셋 불러오기"" 옵션을 활성화 하십시오.", // TO_TRACK_MISSING = 23
            @"중복된 에셋 이름들", // DUPLICATE_NAMES = 24
            @"도시에서 사용된 커스텀 에셋을 확인하십시오", // THESE_ARE_USED = 25
            @"사용 안하는 에셋들.", // NO_USED_ASSETS = 26
            @"해당 활성화된 자산은 현재 필요하지 않습니다(해당 도시에서 미사용 중)", // THESE_ARE_UNNECESSARY = 27
            @"해당 섹션에 이 에셋이 문제로 야기되는 두가지 이유 : (1) 해당 에셋은 활성화 되있으나 불필요함 (2) 해당 에셋이 활성화된 지구 스타일에 있지만 불필요함.", // ENABLED_BUT_UNNECESSARY = 28
            @"불필요한 자산 없음.", // NO_UNNECESSARY_ASSETS = 29
            @"해당 에셋을 추적하려면, ""사용된 에셋 불러오기"" 옵션을 활성화 하십시오.", // TO_TRACK_USED = 30
            @"로딩 현황", // LOADING_STATS = 31
            @"성능", // PERFORMANCE = 32
            @"커스텀 에셋 로딩됨", // CUSTOM_ASSETS_LOADED = 33
            @"에셋들", // ASSETS = 34
            @"로딩 속도", // LOADING_SPEED = 35
            @"에셋들 / 초", // ASSETS_PER_SECOND = 36
            @"커스텀 에셋 로딩 시간", // ASSETS_LOADING_TIME = 37
            @"분:초", // MINUTES_SECONDS = 38
            @"총 걸린 시간", // TOTAL_LOADING_TIME = 39
            @"최대 메모리 사용량", // PEAK_MEMORY_USAGE = 40
            @"가상 메모리", // VIRTUAL_MEMORY = 41
            @"커스텀 에셋 자산 현황", // SHARING_OF_RESOURCES = 42
            @"텍스처", // TEXTURES = 43
            @"시간", // TIMES = 44
            @"소품들", // MATERIALS = 45
            @"Meshe들", // MESHES = 46
            @"건너뛴 prefab들", // SKIPPED_PREFABS = 47
            @"건물 prefab들", // BUILDING_PREFABS = 48
            @"차량 prefab들", // VEHICLE_PREFABS = 49
            @"프롭 prefab들", // PROP_PREFABS = 50
            @"에셋 브라우저", // ASSETS_BROWSER = 51
            @"에셋 오류들", // ASSET_BUGS = 52
            @"에셋 오류", // ASSET_BUG = 53
            @"비공개된 창작물임", // ASSET_USES_PRIVATE_ASSET = 54
            @"창작마당에서 만들어진 프롭이나 나무지만 링크가 존재하지 않음", // NO_LINK_IS_AVAILABLE = 55
            @"해당 모드나 DLC 필요함", // IS_POSSIBLY_DLC = 56
            @"동일한 에셋 이름", // SAME_ASSET_NAME = 57
            @"해당되는 것들 목록", // IN_ALL_OF_THESE = 58
            @"중복 없음.", // NO_DUPLICATES = 59
            @"문제가 발견된 자산들", // PROBLEMS_WERE_DETECTED = 60
            @"유효하지 않은 LOD 텍스처 크기", // INVALID_LOD_TEXTURE_SIZE = 61
            @"자산 이름 충돌", // ASSET_NAMING_CONFLICT = 62
            @"해당 에셋에서 경고가 발생되었습니다.", // OBSERVATIONS_WERE_MADE = 63
            @"매우 큰 LOD 텍스처", // VERY_LARGE_LOD_TEXTURE = 64
            @"가지고 있는", // YOU_HAVE = 65
            @"그러나 미포함됨", // DOES_NOT_CONTAIN = 66
            @"이름이 변경되었음", // NAME_PROBABLY_CHANGED = 67
            @"by 에셋 제작자.", // BY_THE_AUTHOR = 68
            @"매우 큰 LOD mesh", // VERY_LARGE_LOD_MESH = 69
            @"건물과 공원들", // BUILDINGS_AND_PARKS = 70
            @"프롭들", // PROPS = 71
            @"나무들", // TREES = 72
            @"차량들", // VEHICLES = 73
            @"사람들", // CITIZENS = 74
            @"Nets", // NETS = 75
            @"건물가 공원안에 있는 Net들", // NETS_IN_BUILDINGS = 76
            @"건물안에 있는 프롭, 공원 그리고 Net들", // PROPS_IN_BUILDINGS = 77
            @"건물안에 있는 나무, 공원 그리고 Net들", // TREES_IN_BUILDINGS = 78
            @"#당신도 알다시피, LSM 보고서가 loading screen 모드 안에 있는 자산 보고서 보다 우선시 됩니다.", // AS_YOU_KNOW = 79
            @"#해당 파일을 사용하면, 선택된 자산에 대한 보고를 멈출 수 있습니다.", // USING_THIS_FILE = 80
            @"#해당 에셋은 보고되지 않음. 해당 에셋을 다시 보고하려면, 해쉬태그를 넣거나 해당 줄에서 지우십시오.", // THESE_ARE_NOT_REPORTED = 81
            @"#LSM 보고서에 보고된 에셋. 해당 에셋을 다시 보고하려면, 해쉬태그를 넣거나 해당 줄에서 지우십시오.", // LSM_REPORTED_THESE = 82
            @"#사라진 것들 보고서.", // REPORTED_MISSING = 83
            @"#중복된 것들 보고서.", // REPORTED_DUPLICATE = 84
            @"#Go ahead and load a savegame that has some missing assets, then open this file again.", // GO_AHEAD = 85
            @"Mod version is incompatible with the game version", // INCOMPATIBLE_VERSION = 86
            @"Loading options for custom assets", // LOADING_OPTIONS_FOR_ASSETS = 87
            @"커스텀은 여러분이 직접 만든 자산이나 혹은 창작마당 자산입니다", // CUSTOM_MEANS = 88
            @"활성화된 자산 불러오기", // LOAD_ENABLED_ASSETS = 89
            @"콘텐츠 관리자에서 활성화된 자산을 불러옵니다", // LOAD_ENABLED_IN_CM = 90
            @"사용된 에셋 불러오기", // LOAD_USED_ASSETS = 91
            @"여러분 도시에서 사용된 자산을 불러옵니다", // LOAD_USED_IN_YOUR_CITY = 92
            @"텍스처들 공유", // SHARE_TEXTURES = 93
            @"비교하여 복사본 교체함", // REPLACE_DUPLICATES = 94
            @"materials 공유", // SHARE_MATERIALS = 95
            @"meshes 공유", // SHARE_MESHES = 96
            @"썸네일 최적화", // OPTIMIZE_THUMBNAILS = 97
            @"자산 썸네일과 툴팁 텍스쳐 최적화", // OPTIMIZE_TEXTURES = 98
            @"보고서", // REPORTING = 99
            @"보고서 저장 경로:", // SAVE_REPORTS_IN_DIRECTORY = 100
            @"사라지거나 로딩 실패한 에셋을 발견한 보고서를 저장합니다", // SAVE_REPORTS_OF_ASSETS = 101
            @"에셋 에러 점검", // CHECK_FOR_ERRORS = 102
            @"사라지거나 중복되는 에셋 보고 안함:", // DO_NOT_REPORT_THESE = 103
            @"파일 열기", // OPEN_FILE = 104
            @"클릭시 열림", // CLICK_TO_OPEN = 105
            @"Prefab 건너뛰기", // PREFAB_SKIPPING = 106
            @"Prefab는 조립식 에셋을 뜻 함", // PREFAB_MEANS = 107
            @"해당 파일에 적힌 prefabs 이름 건너뛰기 :", // SKIP_THESE = 108
            @"다음번 로딩시 안전모드 설정", // SAFE_MODE = 109
            @"해당 옵션은 바탕화면으로 나갈시 자동적으로 초기화됩니다", // AUTOMATICALLY_DISABLED = 110
            @"모든 차량 제거", // REMOVE_VEHICLE_AGENTS = 111
            @"모든 시민 제거", // REMOVE_CITIZEN_AGENTS = 112
            @"시뮬레이션 에러 복구 시도", // TRY_TO_RECOVER = 113
            @"then order by", // THEN_ORDER_BY = 114
            @"창작마당 아이템", // WORKSHOP_ITEM = 115
            @"Used by", // USED_BY = 116
            @"Order by", // ORDER_BY = 117
            @"에셋 찾기", // FIND_ASSETS = 118
            @"triangles", // TRIANGLES = 119
            @"vertices", // VERTICES = 120
            @"<긴 이름>", // LONG_NAME = 121
            @"커스텀 에셋", // CUSTOM_ASSETS = 122
            @"활성/비활성화된 에셋", // ENABLING_AND_DISABLING = 123
            @"매우 큰 LOD mesh", // EXTREMELY_LARGE_LOD_MESH = 124
            @" / 초", // PER_SECOND = 125
            @"알수없음" // UNKNOWN = 126
        };

    }
}
