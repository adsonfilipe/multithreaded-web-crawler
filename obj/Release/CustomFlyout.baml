   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  * &Extrator de E-mails Divulgador Digital"   WpfApplication5.CustomFlyout   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   #   MahApps.Metro.Controls.Flyout   Name$  customFlyout��$	��400��   Header$ Custom Flyout��   Position$
 Left=� � 	Resources    TextBoxStyle1 �� 
TargetType*   $MahApps.Metro.Controls.TextBoxHelper �� Property  ChromelessButtonTemplate �� Value �� 
TargetType � 	Resources  Key	 g� Duration	
 W� To �� TargetProperty �� 
TargetName W� From ��Name J� SnapsToDevicePixels �Name � ColumnDefinitions ��Name � RowDefinitions ��Name J� Opacity ��Name ��Name J� IsHitTestVisible �� Padding   	Watermark ��Name ! FloatingMessageContainerStyle   MetroAutoCollapsingTextBlock ��Name'    IsClearTextButtonBehaviorEnabled  ChromelessButtonStyle �� Mode �� RelativeSource  ControlsDisabledBrush  �� Triggers! �� Value" �� Binding# �� 
TargetName$ ^� 
Conditions% �� Binding& �� Value' N� EnterActions( W� EasingFunction4  .System.Windows.Media.Animation.ExponentialEase7  1System.Windows.Media.Animation.EasingFunctionBase)   
EasingMode*   Exponent+ N� ExitActions, ]� 
Conditions- �� Property. P� Property/ P� Value  AccentColorBrush0 P� 
SourceName  
GrayBrush8 	 
BlackBrush 
 
WhiteBrush1 �� BasedOn  TextBoxMetroContextMenu+   %MahApps.Metro.Controls.ControlsHelper  HighlightBrush  ContentFontFamily  ContentFontSize  ControlBackgroundBrush  	TextBrush  TextBoxBorderBrush  TextBoxFocusBorderBrush  TextBoxMouseOverBorderBrush  ValidationErrorTemplate2 �� Path3 �� 	Converter4 g� AutoReverse5 g� RepeatBehavior3  -System.Windows.Media.Effects.DropShadowEffect6   
BlurRadius  
BlackColor7   Color8   Opacity9   ShadowDepth��%x$  &	        �� " ��.���  �@ ButtonTemplate# �  ��  � �� �� " �� ���� enterGotFocus .��W� $	 0:0:0.2D�$	
 0.2X�$ Opacity�$ PART_Message���� exitGotFocus .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message���� enterHasText .��W� $	 0:0:0.2D�$	 0.2X�$
 0X�$ Opacity�$ PART_Message���� exitHasText .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message��.R�� .+��� $
 Base��#��z��#��z��#��z��# z � $ PART_InnerGrid��$��2q� �� $ 
TextColumn��$��* ��� $ ButtonColumn��$
��Auto � �� $
��Auto ��� $ 	ButtonRow��$��* �.+��� $ ReadOnlyVisualElement��$��2��$ 0Q�$��1����Z� �� $ PART_ContentHost��$��0q�$��0����.  $��2q�$��1��$��Stretch=���Z� �� $ PART_Message��$��0��#��z��#��z�� .  $	��6,2q�$	 0.6Q�# z��$��1��#��z $y�	Collapsed=�#��z���� $# PART_FloatingMessageContainer��$��2��$��0��#���  .���� $ PART_FloatingMessage��#��z��#��z��#���  #��z #��z���� $ PART_ClearText��$��1��#��z��$��16(���.   . $��2��#���  ���� *(&(Controls:TextBoxHelper.ButtonContent)+$ OneWay=� �� *TemplatedParent+���� *+)(Controls:TextBoxHelper.ButtonFontFamily)+$ OneWay=� �� *TemplatedParent+���� *)'(Controls:TextBoxHelper.ButtonTemplate)+$ OneWay=� �� *TemplatedParent+���� *'%(Controls:ControlsHelper.ButtonWidth)+$ OneWay=� �� *TemplatedParent+�� $ DisabledVisualElement��#���  #��z��#���   .  $ 0Q�# z y��� *;9(Controls:ControlsHelper.DisabledVisualElementVisibility)+$ OneWay=� �� *TemplatedParent+  �� $
! Left��" �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+ �� *Self+.a��� $# PART_ClearText�� � ��$ 0���� $# PART_Message�� � ��$ 1���� $# 
TextColumn�� � ��$
 Auto ��� $# ButtonColumn�� � ��$ * ��� $# PART_ContentHost�� � ��$ 1���� $!  ��" �� *Text+ �� *Self+.a��� $# PART_Message�� � y�$ Visible=�^� $ �� % �� */-(Controls:TextBoxHelper.UseFloatingWatermark)+ �� *Self+& True�� % �� *" (Controls:TextBoxHelper.HasText)+ �� *Self+& True' �� .���� .��W� $	 0:0:0.2D�$
 15X�$ 	MaxHeight�$# PART_FloatingMessageContainer��(   $) 	EaseInOut=�$* 2Q�W� $	 0:0:0.2D�$ Opacity�$# PART_FloatingMessageContainer��W� $	 0:0:0.2D�$
 0X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��(   $) EaseOut=�$* 2Q�+ �� .���� .��W� $	 0:0:0.2D�$
 0X�$ 	MaxHeight�$# PART_FloatingMessageContainer��(   $) 	EaseInOut=�$* 2Q�W� $	 0:0:0.2D�$
 0X�$ Opacity�$# PART_FloatingMessageContainer��W� $	 0:0:0.2D�$
 20X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��(   $) EaseIn=�$* 2Q�]� , �� - �@��TextWrapping$& NoWrap=��� - �@��AcceptsReturn& .  ./��� $# PART_ClearText�� �� *ActualHeight+$ OneWay=� �� *Self+ � ��P� . �@J�IsMouseOver/ . . ��� $
# Base�� �� *0.(Controls:ControlsHelper.MouseOverBorderBrush)+ �� *TemplatedParent+ � ��P� . � {�/ .  . ��� $# DisabledVisualElement�� �@J�Opacity$	 0.6Q�P� . �@��
IsReadOnly/ . . ��� $# ReadOnlyVisualElement�� �@J�Opacity$ 1Q�P� . �@J�	IsFocused/ . . ��� $
# Base�� �� *,*(Controls:ControlsHelper.FocusBorderBrush)+ �� *TemplatedParent+ � ���� $# PART_FloatingMessage��# �   � ���� $# PART_FloatingMessage�� �@J�Opacity$ 1Q�P� $0 PART_ClearText��. �@J�IsMouseOver/ . . ��� $# PART_ClearText��# �   � ���� $# PART_ClearText��# �   � ��P� $0 PART_ClearText��. � ��/ . . ��� $# PART_ClearText��# � 	  � ���� $# PART_ClearText��# � 
  � ��1 �� " ��.���  �@�ContextMenu# �  ��  �@ IsMonitoring . ��  �@ ButtonWidth$ 22Q���  �@��SelectionBrush# �  ��  � ��# �  ��  � ��# �  ��  � ��$ 1q���  � ��$ 26����  � ��# �  ��  � ��# �  ��  � ��$ 0q���  � ��# �  ��  �@ FocusBorderBrush# �  ��  �@ MouseOverBorderBrush# �  ��  �@J�SnapsToDevicePixels . ��  �@=�ErrorTemplate# �  ��  �@��
CaretBrush# � 	 ��  � �� �� " �� ���� enterGotFocus .��W� $	 0:0:0.2D�$	
 0.2X�$ Opacity�$ PART_Message���� exitGotFocus .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message���� enterHasText .��W� $	 0:0:0.2D�$	 0.2X�$
 0X�$ Opacity�$ PART_Message���� exitHasText .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message��.R�� .+��� $
 Base��#��z��#��z��#��z��# z � $ PART_InnerGrid��$��2q� �� $ 
TextColumn��$��* ��� $ ButtonColumn��$
��Auto � �� $
��Auto ��� $ 	ButtonRow��$��* �.+��� $ ReadOnlyVisualElement��$��2��$ 0Q�$��1����Z� �� $ PART_ContentHost��$��0q�$��0����.  $��2q�$��1��$��Stretch=���Z� �� $ PART_Message��$��0��#��z��#��z�� .  $	��6,2q�$	 0.6Q�# z��$��1��#��z $y�	Collapsed=�#��z���� $# PART_FloatingMessageContainer��$��2��$��0��#���  .���� $ PART_FloatingMessage��#��z��#��z��#���  #��z #��z���� $ PART_ClearText��$��1��#��z��$��16(���.  $��2��#���  ���� *(&(Controls:TextBoxHelper.ButtonContent)+$ OneWay=� �� *TemplatedParent+���� *+)(Controls:TextBoxHelper.ButtonFontFamily)+$ OneWay=� �� *TemplatedParent+ �� **((Controls:TextBoxHelper.ClearTextButton)+$ OneWay=� �� *TemplatedParent+���� *'%(Controls:ControlsHelper.ButtonWidth)+$ OneWay=� �� *TemplatedParent+y��� $ OneWay=�$.2 ((Controls:TextBoxHelper.ClearTextButton)� �� *TemplatedParent+3 �� �� $ DisabledVisualElement��#���  #��z��#���   .  $ 0Q�# z y��� *;9(Controls:ControlsHelper.DisabledVisualElementVisibility)+$ OneWay=� �� *TemplatedParent+  �� $
! Left��" �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+ �� *Self+.a��� $# PART_ClearText�� � ��$ 0���� $# PART_Message�� � ��$ 1���� $# 
TextColumn�� � ��$
 Auto ��� $# ButtonColumn�� � ��$ * ��� $# PART_ContentHost�� � ��$ 1���� $!  ��" �� *Text+ �� *Self+.a��� $# PART_Message�� � y�$ Visible=�^� $ �� % �� */-(Controls:TextBoxHelper.UseFloatingWatermark)+ �� *Self+& True�� % �� *" (Controls:TextBoxHelper.HasText)+ �� *Self+& True' �� .���� .��W� $	 0:0:0.2D�$
 15X�$ 	MaxHeight�$# PART_FloatingMessageContainer��(   $) 	EaseInOut=�$* 2Q�W� $	 0:0:0.2D�$ Opacity�$# PART_FloatingMessageContainer��W� $	 0:0:0.2D�$
 0X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��(   $) EaseOut=�$* 2Q�+ �� .���� .��W� $	 0:0:0.2D�$
 0X�$ 	MaxHeight�$# PART_FloatingMessageContainer��(   $) 	EaseInOut=�$* 2Q�W� $	 0:0:0.2D�$
 0X�$ Opacity�$# PART_FloatingMessageContainer��W� $	 0:0:0.2D�$
 20X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��(   $) EaseIn=�$* 2Q�^� $ �� % �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+ �� *Self+	& Right�� % �� **((Controls:TextBoxHelper.ClearTextButton)+ �� *Self+	& False.0��� $# PART_ContentHost�� � ��$ 2���� $# PART_Message�� � ��$ 2��P� . �@J�IsMouseOver/ . . ��� $
# Base�� �� *0.(Controls:ControlsHelper.MouseOverBorderBrush)+ �� *TemplatedParent+ � ��P� . � {�/ .  . ��� $# DisabledVisualElement�� �@J�Opacity$	 0.6Q�P� . �@��
IsReadOnly/ . . ��� $# PART_ClearText�� � {� .  �� $# ReadOnlyVisualElement�� �@J�Opacity$ 1Q�P� . �@J�	IsFocused/ . . ��� $
# Base�� �� *,*(Controls:ControlsHelper.FocusBorderBrush)+ �� *TemplatedParent+ � ���� $# PART_FloatingMessage��# �   � ���� $# PART_FloatingMessage�� �@J�Opacity$ 1Q�P� $0 PART_ClearText��. �@J�IsMouseOver/ . . ��� $# PART_ClearText��# �   � ���� $# PART_ClearText��# �   � ��P� $0 PART_ClearText��. � ��/ . . ��� $# PART_ClearText��# � 	  � ���� $# PART_ClearText��# � 
  � ��]� , �� - �@ HasText& .  �� - �@J�	IsFocused& . ' �� .���� .��W� $	 0:0:0.2D�$	
 0.2X�$ Opacity�$ PART_Message��+ �� .���� .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message��P� . �@ HasText/ . ' �� .���� .��W� $	 0:0:0.2D�$	 0.2X�$
 0X�$ Opacity�$ PART_Message��+ �� .���� .��W� $	 0:0:0.2D�$ Opacity�$ PART_Message��P� . �@ IsWaitingForData/ . ' �� .���� .��W� 4 . $	 0:0:2D�$ 0X�$5 Forever��$
 1X�$ (Effect).Opacity�$
 Base��. ��� $
# Base�� �@J�Effect   $6 10Q�#7 �  $8 0Q�$9 0Q�P� . �@ IsWaitingForData/ .  . ��� $
# Base�� Z�  �@J�Effect.���  �� $��5* ��� $	��11* �.+��� -   : ��Name$: textbox_search��;   UseFloatingWatermark; .  $ 	Pesquisar��< �� 	MaxLength$< 80��= �� MaxLines$= 1��$��0,0,3,0q�$��30��$	��Top=�#���   $��
10,20,10,0q�$��2��$��Segoe UI Semibold)�$��13.333(�>   ButtonCommand> �� $2 SelectInvHidCommand�{��� *SearchBoxEnabled+.��?   ButtonContent? �� $��20��$��20��#���  @ J� OpacityMask@ !� A j� Stretch$
A Fill=�  appbar_arrow_rightB !� Visual#B �  .��� $
��Left=�$��59��$��0,55,0,0q�$	��Top=�$	��380��$��2��.+�*   $MahApps.Metro.Controls.NumericUpDown  -   C  Name$C numeric_ini2��D   Minimum$D 1Q�E   Value$E 1X�F   Maximum$	F 100Q�G   Interval$G 1Q�$��
134,11,0,0q�$��33��$	��Top=�H J� RenderTransformOrigin$H 1.853,1.369&�$
��Left=�$��81��  -   $C numeric_end2��$E 1X�$	F 100Q�$G 1Q�$��
299,11,0,0q�$��33��$	��Top=�D �� *Value+I �� ElementName$I numeric_ini2��$ TwoWay=��� -   J ��Name$J label11��$	��De:��$
��Left=�$��	98,11,0,0q�$	��Top=�$��31��$��33��$��14.667(�$��Segoe UI Historic)��� -   $J label22��$��Até:��$
��Left=�$��
259,11,0,0q�$	��Top=�$H 1.406,0.705&�$��14.667(�$��Segoe UI Historic)�$��33���� -   $J label11_Copy��$��Normal"�  ToggleSwitchHeaderFontSize#���     ToggleSwitchHeaderFontFamily#���  $
��Left=�$��
12,11,0,15q�$
 0.65Q�$��Center=�$��	Páginas:��$��74��$��33��&   System.Windows.Media.TextOptionsK   TextFormattingMode$K Display=�$H 1.027,0.667&�$��0,5,0,0q�)	   #MahApps.Metro.Controls.ToggleSwitch	  L 	  Header$L Incluir URLs Externas��M 	  OnLabel$	M Sim��N 	  OffLabel$
N Não��$��10,69,0,-69q�O � Cursor$O  ��P � UseLayoutRoundingP . $��0q�$
��Left=�$��Center=�$��Center=��� -   $: textBox��$ Insira uma URL por linha��; . $
��Left=�$	��320��$��
10,195,0,0q�Q �� TextWrapping$
Q Wrap=�$	��Top=�$	��380��