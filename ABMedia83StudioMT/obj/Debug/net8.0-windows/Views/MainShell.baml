   M S B A M L   `   `   `  ����L  HABMedia83StudioMT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ABMedia83Studio.ControlsABMedia83Studio.Controls  5   	   G CAlbert.Win32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32Albert.Win32.Controls 5   	   A0clr-namespace:Albert.Win32;assembly=Albert.Win32Albert.Win32 5      %    ABMedia83Studio.Views.MainShell   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ABMedia83Studio.Controls     5   	   Gc9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32     5   	   >w0clr-namespace:Albert.Win32;assembly=Albert.Win32     5      $	��450��5
   !   $	��800��6.     � Title  6	   �� *Title+.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   o� -   5         o�Name$ mainMenu��5      .@�5      m� $
��File��6   .@�5      m�  m� Command$	 New��6   m� 5      $
 Open��6   m� 5      $
 Save��6   m� 5      $ w:DesktopCommands.SaveAs��6   �� 5      m� 5      $ w:DesktopCommands.Import��6   m� 5      $ w:DesktopCommands.Export��6   �� 5      m� 5      $ w:DesktopCommands.Quit��6   5      m� 5      $
��Edit��6   .@�5      m� $	 Cut��6   m� 5       $
 Copy��6   m� 5!      $ Paste��6   �� 5"      m� 5#      $ 	SelectAll��6   5$      m� 5%      $
��View��6   .@�5&      m� -   5         m�Name$ statusMenuItem��5&       m� 	IsChecked$
 True��65    m� IsCheckable$
 True��6F   $��Show StatusBar��6Y   5'      m� 5(      $��Tools��6   .@�5)      m� $" w:DesktopCommands.RunConsole��6   m� 5*      $ w:DesktopCommands.LogInfo��6   5+      m� 5,      $��Window��6   .@�5-      m� -   5        $��Code Studio��5-      
 � Tag$
 Code��6D   m� 5.      -   5        $��Design Studio��5.      $ Design��6;   m� 5/      -   5        $��Document Studio��5/      $ Document��6<   m� 50      -   5        $��Social Media Studio��50      $ Social��6@   51      m� 52      $
��Help��6   .@�53      m� $ w:DesktopCommands.About��6   54      57       � 5:   
   -   5          �Name$ frame��5:   0   	  � NavigationUIVisibility$	 Hidden=�6   $��1��6?   �� 5=   
   -   5        
 ��Name$
 	statusBar��5=      $��2��6'   5?      5A      5B      