   M S B A M L   `   `   `  ????V  RVerTokenSeguridad_Actualice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:VerTokenSeguridad_ActualiceVerTokenSeguridad_Actualice  5   	   ,    &VerTokenSeguridad_Actualice.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:VerTokenSeguridad_Actualice     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          ? Title$  
MainWindow??5   	   $??305.475??6   $??824.025??6-    ? WindowStyle$
 None=?5
   	   
??????  ? AllowsTransparency .  ? WindowState$ Normal=?5   #    ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	      MaterialDesignBody#???   5   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignFont#???  5   	   .??5      ??  ?? CornerRadius$ 12??6   $??2q?5      ???	#FFF6F7FB???	#FF7A6D6D._?5#   
   ? 	 ? RowDefinitions	 5$      ?? 5%      $??39 ?6    ?? 5&      $??* ?6    ?? 5'      $??15 ?6    .+?5,      ?? $ 	11,11,0,0??6   ???	#FF252733._?5-      ? 
 ? ColumnDefinitions
 5.      ?? 5/      ?? 50      $??35 ?6+   ?? 51      $??35 ?6+   ?? 52      $??5 ?6+   .+?56      ?? $3??-TOKEN ACTUALIZE: René Lázaro Collado Artega??6    ???	#FFE0E0E0$??10(?58       $??
Montserrat)?59       $??0??5:       $??Center=?5;       $??
10,14,5,13q?5<       $??12??64   ?? 5>      -   5          MaterialDesignFlatButton#??[ 5>       ? ToolTip$ 	Minimizar??5?      $??1??5@      $
??Auto??5A      ???	#008373A0$??0,2,0,0q?5D      $??0q?5E      +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback ?#9A9A9A???#CACACA.??5H      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=?62   $??20??6H   $??20??6T   ???	#FFF3E0E76_   5I      ?? 5K      -   5        #??[ 5K      $ Cerrar??5L      $??2??5M      $
??Auto??5N      ???	#008373A0$??0,2,0,0q?5Q      $??0q?5R       ?#9A9A9A???#CACACA.??5U        $ CloseOutline=?62   $??20??6F   $??20??6R   ???	#FFF3E0E76]   5V      5W      5X      ? 5Z      $??1??6     MaterialDesignPaper#???  6!   .+?5[      ?? -   5         ??Name$ TB_Token??5[      $
??Left=?6,   $??48??6G   $??	54,74,0,0q?6S    ?? TextWrapping$
 Wrap=?6f   $??este es el token??6z   $	??Top=?6?   $	??693??6?    ?? 
IsReadOnly .  ?? MinLines$ 4??6?   ?? 5\      -   5         ??Name$ label??5\      $??Token
??6'   $
??Left=?6A   $??49,3,0,0q?6\   $	??Top=?6n   $	??250??6?   $??66??6?   $??
Bauhaus 93)?6?   $??48(?6?   ?? 5]      -   5         ??Name$ button??5]      $
??Left=?6*   $??
695,37,0,0q?6E   $	??Top=?6Y   $??52??6q   ??5`        5a      $ ContentCopy=?62   $??Center=?6E   $??Center=?6b   5d      ?? 5e      -   5        $ button_Copy??5e      $
??Left=?6/   $??
54,141,0,0q?6J   $	??Top=?6^   $??52??6v   .??5h        $ FileFind=?6.   $??Center=?6>   $??Center=?6[   $??32??6v   $??45??6?   5j      ?? 5k      -   5        $ TB_Direccion_Del_TXT??5k      $
??Left=?68   $??23??6S   $??124,150,0,0q?6_   $
 Wrap=?6t   $	??Top=?6?   $	??623??6?   $ Direccion del txt??6?   ?? 5l      -	   5        $ TB_Nombre_del_txt??5l      $
??Left=?65   $??23??6P   $??124,198,0,0q?6\   $
 Wrap=?6q   $	??Top=?6?   $	??547??6?   $ Nombre del TXT??6?   ?? 5m      -
   5        $ button_Copy2??5m      $
??Left=?60   $??695,191,0,0q?6K   $	??Top=?6`   $??52??6x   .??5p        $ FileDownload=?6.   $??Center=?6B   $??Center=?6_   $??32??6z   $??27??6?   5r      ?? 5s      -   5         ??Name$ CB_Discos_Conectados??5s      $
??Left=?5u      $??
49,198,0,0q?66   $	??Top=?6J   $??57??6b   5w      5x      5y      5{      