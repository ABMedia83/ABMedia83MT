   M S B A M L   `   `   `  ���� L  HABMedia83StudioMT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ABMedia83StudioMT.ControlsABMedia83StudioMT.Controls  A%clr-namespace:ABMedia83StudioMT.ViewsABMedia83StudioMT.Views  G CAlbert.Win32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32Albert.Win32.Controls W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089^ ZICSharpCode.AvalonEdit, Version=6.3.0.90, Culture=neutral, PublicKeyToken=9cc39be672370310&    Albert.Win32.Controls.ViewDialog  �� 
TargetType �� Property   ABBackground �� Value'   !ABMedia83StudioMT.Views.MainShell'  !ICSharpCode.AvalonEdit.TextEditor  ABForeground%  Albert.Win32.Controls.WriterBox m� Command  LeftScrollViewer �� 
TargetType � ColumnDefinitions � RowDefinitions  Primary �� CanContentScroll ��Name	 �� VerticalOffset
 � Value �� ScrollableHeight � Maximum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� Orientation �� HorizontalOffset �� ScrollableWidth �� ViewportWidth, �� %ComputedHorizontalScrollBarVisibility)  #Albert.Win32.Controls.RichWriterBox �� 	Resources  txtBase  txtField �� BasedOn&   Albert.Win32.Controls.PushButton  pushBase  abRadialChrome  abRadialChrome5 	 abRadialChrome2 
 	abAccent4(  "Albert.Win32.Controls.OptionButton  optBase'  !Albert.Win32.Controls.CheckButton  chkBase  	Secondary �� Orientation K� IsItemsHost ��Name �Name m� IsSubmenuOpen � AllowsTransparency J� SnapsToDevicePixels  MenuScrollViewer-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation �� Triggers  P� Property! P� Value" �� 
TargetName# P� 
SourceName$ z� SharedSizeGroup% ��Name& F�Name' ��Name( m� InputGestureText) �� EndPoint* �� 
StartPoint  BorderMediumColor+ � Color, � Offset  
GlyphColor- �� Color. � HorizontalOffset  MenuPopupBrush  ControlMouseOverColor/ �� Triggers 0 m� TopLevelHeaderTemplateKey1 m� TopLevelItemTemplateKey2 m� SubmenuHeaderTemplateKey3 m� SubmenuItemTemplateKey $  MenuScrollingVisibilityConverter  MenuScrollButton4 �� LineUpCommand5 �� RelativeSource6 �� FallbackValue7 `� 	Converter8 `� ConverterParameter9 �� Path  UpArrow: �� LineDownCommand  	DownArrow�� H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     2local(clr-namespace:ABMedia83StudioMT.Controls  7ic.http://icsharpcode.net/sharpdevelop/avalonedit  .view%clr-namespace:ABMedia83StudioMT.Views  ?c9clr-namespace:Albert.Win32.Controls;assembly=Albert.Win32  %�  '         7   '       7   '  g     7   7  '  p    7   7  7   &	     7  '  e    7   &	 �    7   &	 �    7  &	 �    7  7  7 	 7  7  7 
 &	 �    7  7  7 	 7  7  7 
 &	 �	    7  7  7 	 7  7  7 
 'o� �
    7   7  7  (�� �    *$"MenuItem.TopLevelHeaderTemplateKey+)7   7   7  (�� �    *" MenuItem.TopLevelItemTemplateKey+)7   7  (�� �    *!MenuItem.SubmenuItemTemplateKey+)7   7  (�� �    *#!MenuItem.SubmenuHeaderTemplateKey+)7   'm� B    70 71 72 73 &	 �    &	 �    7  7  �� "    .���  � ��8   �� "   .���  �@�WindowState$ 	Maximized=���  � ��8   �� "   .���  � ��
 �������  � ��$	 1.1q���  � ��8   ��  � ��8  ��  � ��$
 14pt(���  � ��$ Segoe Print)���  �@ ShowLineNumbers$ False����  �@ WordWrap$
 True����  �@ ShowLineNumbers$
 True���� "   .���  � ��8   ��  � ��8  ��  � ��$
 14pt(���  �@��
AcceptsTab$
 True����  �@��AcceptsReturn$
 True����  �@��	IsEnabled$
 True����  � ��
 �������  � ��$	 1.1q���  �@��TextWrapping$
 Wrap=���  � ��$ Segoe Print)���  �@�ContextMenu �� 
������ $��0q�8�� .@�m� $	 Cut��m� $
 Copy��m� $ Paste���� "  ��.���  �@�OverridesDefaultStyle$
 True����  � �� �� " ��.R��  �� $
��Auto ���  �� �� $
��Auto �.+��� $��1��$��0,1,1,1q�8��  ._��� # z���� $ PART_VerticalScrollBar��#
 z	 # z # z #y�z �� $ PART_HorizontalScrollBar��$ 
Horizontal=�$��1��$��1��#
 z # z # z #y�z �� "   .���  � ��
 �   ���  � ��
 �������  � ��$
 13pt(���  �@��	IsEnabled$
 True����  �@�ContextMenu �� 
������ $��0q�8��  .@�m� $	 Cut��m� $
 Copy��m� $ Paste�� ���� '��       "  ��.���  � ��
 �������  � ��
 �   ��� '��       "  ��.���  � ��
 �������  � ��
 �   ��� "  ��.���  � ��8   ��  � ��
 �������  � ��$
 13pt(���  � ��$ Courier New)���  �@��TextWrapping$
 Wrap=���  �@��AcceptsReturn$
 True����  �@��
AcceptsTab$
 True����  �@��	IsEnabled$
 True���� "  ��8   .���  � ��$ 30����  � ��$
 13pt(���  �@��
AcceptsTab$ False����  �@��AcceptsReturn$ False����  � ��$ Courier New)��� "   .���  � ��8   ��  �@ BackgroundMouseOver8  ��  �@ BackgroundPressed8  ��  � ��8  ��  � ��8  ��  �@ ForegroundPressed8  ��  � ��$
 14pt(���  � ��$ Segoe UI)���  � ��$ 5q��� "   .���  � ��8   ��  �@ BackgroundMouseOver8  ��  �@ BackgroundChecked8  ��  � ��8  ��  � ��8  ��  �@ ForegroundChecked8  ��  � ��$
 18pt(���  � ��$ 5q���  �@ Stretch$ Uniform=���  � ��$ Segoe UI Black)��� "   .���  � ��8   ��  �@ BackgroundMouseOver8  ��  �@ BackgroundChecked8  ��  � ��8  ��  � ��8  ��  �@ ForegroundChecked8  ��  � ��$
 18pt(���  � ��$ 5q���  �@ Stretch$ Uniform=���  � ��$ Segoe UI Black)��� "  o� ���� '��       "  ��.���  � ��$ Stretch=�.���  �@�OverridesDefaultStyle$
 True����  � ��8   ��  � ��8  ��  �@J�SnapsToDevicePixels$
 True����  � �� �� " o�.R��� $	��0.2q�
�������8�� ._��� $
}�True��$ 
Horizontal=�$
 True���� " m�.R��� $ Border��8��  ._�� .+��� $��6,3,6,3q�$��Header��$
��True��� $ Popup��$��Bottom=�#��z $
 True��$|�False��$
��Fade=�.���� $ SubmenuBorder��$
 True��$��0q�8�� ._��� #���  .���� $
 True��$ Cycle=� P� "  �@m�IsSuspendingPopupAnimation$
! true��. ��� $" Popup�� � ��$
 None=�P�   �@m�IsHighlighted$
! true��. ��� $" Border�� � ��
 ���� �� $" Border��8   � ��P� $# Popup��  �@�AllowsTransparency$
! True��. ��� $" SubmenuBorder�� �@��CornerRadius$ 0,0,4,4���� $" SubmenuBorder�� �@��Padding$ 0,0,0,3q�P�   � {�$! False��. ���  � ��
 ������� " m�.R��� $ Border��8��  $	��1.5q�
�������._�� .+��� $��6,3,6,3q�$��Header��$
��True�� P�   �@m�IsHighlighted$
! true��. ��� $" Border��8   � ��P�   � {�$! False��. ���  � ��
 ������� " m�.R��� $ Border��$��0q�8��  
�������._��  �� $
��Auto �$
$ Icon���� $��* ��� $
��Auto �$$ Shortcut���� $��13 �.+��� $
% Icon��$��6,0,6,0q�$��Center=�$
��Icon���� $ Check��$��13��$��13��$y�	Collapsed=�$��6,0,6,0q�$��0q�._�F� $& 	CheckMark��$��7��$��7��$y�Hidden=�$ False��$��2��
�������+����        ���j ��j �    ��j ���j     	�� $% 
HeaderHost��$��1��$��Header��$
��True���� $' InputGestureText��$��2��$	��8pt(�#��z( $��5,2,0,2q�$��Right=� P� ! Z�   � ��P� ! Z�   �@m�Icon. ��� $
" Icon�� � y�$ Hidden=�P�   �@m�	IsChecked$
! true��. ��� $" 	CheckMark�� � y�$ Visible=�P�   �@m�IsCheckable$
! true��. ��� $" Check�� � y�$ Visible=��� $
" Icon�� � y�$ Hidden=�P�   �@m�IsHighlighted$
! true��. ��� $" Border��8   � ���� $" Border�� � �� �� $) 0.5,1&�$* 0.5,0&�.��� #+ �  $, 0Q�� $+ Transparent��$, 1Q�P�   � {�$! false���� " m�.R��� $ Border��$��1q�8��  ._��  �� $
��Auto �$
$ Icon���� $��* ��� $
��Auto �$$ Shortcut���� $��13 �.+��� $
% Icon��$��6,0,6,0q�$��Center=�$
��Icon���� $% 
HeaderHost��$��1��$��Header��$
��True���� $' InputGestureText��$��2��#��z( $��5,2,2,2q�$��Right=�F� $��3��$��Center=�$��Center=�"����        �    ��j � 	= �g5 	���� #- �  � $ Popup��$��Right=�$. -4��#��z $
 True��$|�False��$
��Fade=�.���� $ SubmenuBorder��$
 True��#���  $��1q����� #- �  ._��� $
��True��#���  .���� $
 True��$ Cycle=� P� ! Z�   �@m�Icon. ��� $
" Icon�� � y�$ 	Collapsed=�P�   �@m�IsHighlighted$
! true��. ��� $" Border�� � �� �� $) 0.5,1&�$* 0.5,0&�.��� $+ Transparent��$, 0Q�� #+ �  $, 1Q��� $" Border�� � �� �� $) 0.5,1&�$* 0.5,0&�.��� #+ �  $, 0Q�� $+ Transparent��$, 1Q�P� $# Popup��  �@�AllowsTransparency$
! True��. ��� $" SubmenuBorder�� �@��CornerRadius$ 4���� $" SubmenuBorder�� �@��Padding$ 0,3,0,3q�P�   � {�$! false��. ���  � ��
 ������� "  m�.���  �@�OverridesDefaultStyle$
 True��/ P�   �@m�Role$! TopLevelHeader=�. ���  � ��8   ��  �@�IsSharedSizeScope$
 true��P�   �@m�Role$! TopLevelItem=�. ���  � ��8  P�   �@m�Role$! SubmenuHeader=�. ���  � ��8  P�   �@m�Role$! SubmenuItem=�. ���  � ��8  l� �� "  �� Z� .���  � ��$ Hidden=���  � ��$
 Auto=���  � �� �� " ��.R�� $
 True�� �� $��* � �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��1��$��0��._��� #��z���� #���  $��0��$��0��#��Z4 $|�False������ 5 �� *TemplatedParent+y�`� $6 Visibility.Collapsed��87   $8 0��.1��� $)9 #ComputedVerticalScrollBarVisibility�5 �� *TemplatedParent+�� $9 VerticalOffset�5 �� *TemplatedParent+�� $9 ExtentHeight�5 �� *TemplatedParent+�� $9 ViewportHeight�5 �� *TemplatedParent+.��F� #��� ��#���  �� #���  $��2��$��0��#��Z: $|�False������ 5 �� *TemplatedParent+y�`� $6 Visibility.Collapsed��87  $	8 100��.1��� $)9 #ComputedVerticalScrollBarVisibility�5 �� *TemplatedParent+�� $9 VerticalOffset�5 �� *TemplatedParent+�� $9 ExtentHeight�5 �� *TemplatedParent+�� $9 ViewportHeight�5 �� *TemplatedParent+.��F� #��� ��#���  