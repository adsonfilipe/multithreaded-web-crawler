   M S B A M L   `   `   `  ���� a  ]Extrator de E-mails Divulgador Digital, Version=1.0.8.3, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication5WpfApplication5  T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls      WpfApplication5.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:WpfApplication5     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     -   )  #MahApps.Metro.Controls.ButtonHelper    PreserveTextCase  .  � Title$6 0Sistema Extrator de E-mails | Divulgador Digital��$��656.213��$��1280.885��
������� � Icon$: 4pack://application:,,,/Resources/iconeDivulgador.png��   AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   ��Z�  � 	Resources   TextBoxStyle1 �� 
TargetType*  $MahApps.Metro.Controls.TextBoxHelper �� Property  ChromelessButtonTemplate �� Value �� 
TargetType	 � 	Resources  Key
 g� Duration	 W� To �� TargetProperty �� 
TargetName W� From ��Name J� SnapsToDevicePixels �Name � ColumnDefinitions ��Name � RowDefinitions ��Name J� Opacity ��Name ��Name J� IsHitTestVisible �� Padding   	Watermark ��Name ! FloatingMessageContainerStyle   MetroAutoCollapsingTextBlock ��Name'    IsClearTextButtonBehaviorEnabled  ChromelessButtonStyle �� Mode  �� RelativeSource  ControlsDisabledBrush! �� Triggers" �� Value# �� Binding$ �� 
TargetName% ^� 
Conditions& �� Binding' �� Value( N� EnterActions) W� EasingFunction4  .System.Windows.Media.Animation.ExponentialEase7  1System.Windows.Media.Animation.EasingFunctionBase*   
EasingMode+   Exponent, N� ExitActions- ]� 
Conditions. �� Property/ P� Property0 P� Value1 P� 
SourceName  
GrayBrush8 	 
BlackBrush 
 
WhiteBrush2 �� BasedOn  TextBoxMetroContextMenu+  %MahApps.Metro.Controls.ControlsHelper  HighlightBrush  ContentFontFamily  ContentFontSize  ControlBackgroundBrush  	TextBrush  TextBoxBorderBrush  TextBoxFocusBorderBrush  TextBoxMouseOverBorderBrush  ValidationErrorTemplate3 �� Path4 �� 	Converter5 g� AutoReverse6 g� RepeatBehavior3  -System.Windows.Media.Effects.DropShadowEffect7   
BlurRadius  
BlackColor8   Color9   Opacity:   ShadowDepth   BooleanToVisibilityConverter��%�$  &	       &	 �$    �� " ��.���  �@ ButtonTemplate# �  ��  � �� �� " ��	 ���� enterGotFocus .��W� $
 0:0:0.2D�$	 0.2X�$ Opacity�$ PART_Message���� exitGotFocus .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message���� enterHasText .��W� $
 0:0:0.2D�$	 0.2X�$ 0X�$ Opacity�$ PART_Message���� exitHasText .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message��.R�� .+��� $
 Base��#��z��#��z��#��z��# z � $ PART_InnerGrid��$��2q� �� $ 
TextColumn��$��* ��� $ ButtonColumn��$
��Auto � �� $
��Auto ��� $ 	ButtonRow��$��* �.+��� $ ReadOnlyVisualElement��$��2��$ 0Q�$��1����Z� �� $ PART_ContentHost��$��0q�$��0����.  $��2q�$��1��$��Stretch=���Z� �� $ PART_Message��$��0��#��z��#��z�� .  $	��6,2q�$	 0.6Q�# z��$��1��#��z $y�	Collapsed=�#��z���� $# PART_FloatingMessageContainer��$��2��$��0��#���  .���� $ PART_FloatingMessage��#��z��#��z��#���  #��z #��z���� $ PART_ClearText��-   $��1��#��z��$��16(���.   . $��2��#���  $
��Auto������ *(&(Controls:TextBoxHelper.ButtonContent)+$ OneWay=�  �� *TemplatedParent+���� *+)(Controls:TextBoxHelper.ButtonFontFamily)+$ OneWay=�  �� *TemplatedParent+���� *)'(Controls:TextBoxHelper.ButtonTemplate)+$ OneWay=�  �� *TemplatedParent+���� *'%(Controls:ControlsHelper.ButtonWidth)+$ OneWay=�  �� *TemplatedParent+�� $ DisabledVisualElement��#���  #��z��#���   .  $ 0Q�# z $
��Left=�$	��380��y��� *;9(Controls:ControlsHelper.DisabledVisualElementVisibility)+$ OneWay=�  �� *TemplatedParent+! �� $
" Left��# �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+  �� *Self+.a��� $$ PART_ClearText�� � ��$ 0���� $$ PART_Message�� � ��$ 1���� $$ 
TextColumn�� � ��$
 Auto ��� $$ ButtonColumn�� � ��$ * ��� $$ PART_ContentHost�� � ��$ 1���� $"  ��# �� *Text+  �� *Self+.a��� $$ PART_Message�� � y�$ Visible=�^� % �� & �� */-(Controls:TextBoxHelper.UseFloatingWatermark)+  �� *Self+' True�� & �� *" (Controls:TextBoxHelper.HasText)+  �� *Self+' True( �� .���� .��W� $
 0:0:0.2D�$ 15X�$ 	MaxHeight�$# PART_FloatingMessageContainer��)   $* 	EaseInOut=�$+ 2Q�W� $
 0:0:0.2D�$ Opacity�$# PART_FloatingMessageContainer��W� $
 0:0:0.2D�$ 0X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��)   $* EaseOut=�$+ 2Q�, �� .���� .��W� $
 0:0:0.2D�$ 0X�$ 	MaxHeight�$# PART_FloatingMessageContainer��)   $* 	EaseInOut=�$+ 2Q�W� $
 0:0:0.2D�$ 0X�$ Opacity�$# PART_FloatingMessageContainer��W� $
 0:0:0.2D�$ 20X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��)   $* EaseIn=�$+ 2Q�]� - �� . �@��TextWrapping$' NoWrap=��� . �@��AcceptsReturn' .  ./��� $$ PART_ClearText�� �� *ActualHeight+$ OneWay=�  �� *Self+ � ��P� / �@J�IsMouseOver0 . . ��� $
$ Base�� �� *0.(Controls:ControlsHelper.MouseOverBorderBrush)+  �� *TemplatedParent+ � ��P� / � {�0 .  . ��� $$ DisabledVisualElement�� �@J�Opacity$	 0.6Q�P� / �@��
IsReadOnly0 . . ��� $$ ReadOnlyVisualElement�� �@J�Opacity$ 1Q�P� / �@J�	IsFocused0 . . ��� $
$ Base�� �� *,*(Controls:ControlsHelper.FocusBorderBrush)+  �� *TemplatedParent+ � ���� $$ PART_FloatingMessage��# �    � ���� $$ PART_FloatingMessage�� �@J�Opacity$ 1Q�P� $1 PART_ClearText��/ �@J�IsMouseOver0 . . ��� $$ PART_ClearText��# �   � ���� $$ PART_ClearText��# �    � ��P� $1 PART_ClearText��/ � ��0 . . ��� $$ PART_ClearText��# � 	  � ���� $$ PART_ClearText��# � 
  � ��2 �� " ��.���  �@�ContextMenu# �  ��  �@ IsMonitoring . ��  �@ ButtonWidth$ 22Q���  �@��SelectionBrush# �  ��  � ��# �  ��  � ��# �  ��  � ��$ 1q���  � ��$ 26����  � ��# �  ��  � ��# �  ��  � ��$ 0q���  � ��# �  ��  �@ FocusBorderBrush# �  ��  �@ MouseOverBorderBrush# �  ��  �@J�SnapsToDevicePixels . ��  �@=�ErrorTemplate# �  ��  �@��
CaretBrush# � 	 ��  � �� �� " ��	 ���� enterGotFocus .��W� $
 0:0:0.2D�$	 0.2X�$ Opacity�$ PART_Message���� exitGotFocus .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message���� enterHasText .��W� $
 0:0:0.2D�$	 0.2X�$ 0X�$ Opacity�$ PART_Message���� exitHasText .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message��.R�� .+��� $
 Base��#��z��#��z��#��z��# z � $ PART_InnerGrid��$��2q� �� $ 
TextColumn��$��* ��� $ ButtonColumn��$
��Auto � �� $
��Auto ��� $ 	ButtonRow��$��* �.+��� $ ReadOnlyVisualElement��$��2��$ 0Q�$��1����Z� �� $ PART_ContentHost��$��0q�$��0����.  $��2q�$��1��$��Stretch=���Z� �� $ PART_Message��$��0��#��z��#��z�� .  $	��6,2q�$	 0.6Q�# z��$��1��#��z $y�	Collapsed=�#��z���� $# PART_FloatingMessageContainer��$��2��$��0��#���  .���� $ PART_FloatingMessage��#��z��#��z��#���  #��z #��z���� $ PART_ClearText��$��1��#��z��$��16(���.  $��2��#���  ���� *(&(Controls:TextBoxHelper.ButtonContent)+$ OneWay=�  �� *TemplatedParent+���� *+)(Controls:TextBoxHelper.ButtonFontFamily)+$ OneWay=�  �� *TemplatedParent+ �� **((Controls:TextBoxHelper.ClearTextButton)+$ OneWay=�  �� *TemplatedParent+���� *'%(Controls:ControlsHelper.ButtonWidth)+$ OneWay=�  �� *TemplatedParent+y��� $ OneWay=�$.3 ((Controls:TextBoxHelper.ClearTextButton)�  �� *TemplatedParent+4 �� �� $ DisabledVisualElement��#���  #��z��#���   .  $ 0Q�# z y��� *;9(Controls:ControlsHelper.DisabledVisualElementVisibility)+$ OneWay=�  �� *TemplatedParent+! �� $
" Left��# �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+  �� *Self+.a��� $$ PART_ClearText�� � ��$ 0���� $$ PART_Message�� � ��$ 1���� $$ 
TextColumn�� � ��$
 Auto ��� $$ ButtonColumn�� � ��$ * ��� $$ PART_ContentHost�� � ��$ 1���� $"  ��# �� *Text+  �� *Self+.a��� $$ PART_Message�� � y�$ Visible=�^� % �� & �� */-(Controls:TextBoxHelper.UseFloatingWatermark)+  �� *Self+' True�� & �� *" (Controls:TextBoxHelper.HasText)+  �� *Self+' True( �� .���� .��W� $
 0:0:0.2D�$ 15X�$ 	MaxHeight�$# PART_FloatingMessageContainer��)   $* 	EaseInOut=�$+ 2Q�W� $
 0:0:0.2D�$ Opacity�$# PART_FloatingMessageContainer��W� $
 0:0:0.2D�$ 0X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��)   $* EaseOut=�$+ 2Q�, �� .���� .��W� $
 0:0:0.2D�$ 0X�$ 	MaxHeight�$# PART_FloatingMessageContainer��)   $* 	EaseInOut=�$+ 2Q�W� $
 0:0:0.2D�$ 0X�$ Opacity�$# PART_FloatingMessageContainer��W� $
 0:0:0.2D�$ 20X�$8 2(UIElement.RenderTransform).(TranslateTransform.Y)�$ PART_FloatingMessage��)   $* EaseIn=�$+ 2Q�^� % �� & �� *+)(Controls:TextBoxHelper.ButtonsAlignment)+  �� *Self+	' Right�� & �� **((Controls:TextBoxHelper.ClearTextButton)+  �� *Self+	' False.0��� $$ PART_ContentHost�� � ��$ 2���� $$ PART_Message�� � ��$ 2��P� / �@J�IsMouseOver0 . . ��� $
$ Base�� �� *0.(Controls:ControlsHelper.MouseOverBorderBrush)+  �� *TemplatedParent+ � ��P� / � {�0 .  . ��� $$ DisabledVisualElement�� �@J�Opacity$	 0.6Q�P� / �@��
IsReadOnly0 . . ��� $$ PART_ClearText�� � {� .  �� $$ ReadOnlyVisualElement�� �@J�Opacity$ 1Q�P� / �@J�	IsFocused0 . . ��� $
$ Base�� �� *,*(Controls:ControlsHelper.FocusBorderBrush)+  �� *TemplatedParent+ � ���� $$ PART_FloatingMessage��# �    � ���� $$ PART_FloatingMessage�� �@J�Opacity$ 1Q�P� $1 PART_ClearText��/ �@J�IsMouseOver0 . . ��� $$ PART_ClearText��# �   � ���� $$ PART_ClearText��# �    � ��P� $1 PART_ClearText��/ � ��0 . . ��� $$ PART_ClearText��# � 	  � ���� $$ PART_ClearText��# � 
  � ��]� - �� . �@ HasText' .  �� . �@J�	IsFocused' . ( �� .���� .��W� $
 0:0:0.2D�$	 0.2X�$ Opacity�$ PART_Message��, �� .���� .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message��P� / �@ HasText0 . ( �� .���� .��W� $
 0:0:0.2D�$	 0.2X�$ 0X�$ Opacity�$ PART_Message��, �� .���� .��W� $
 0:0:0.2D�$ Opacity�$ PART_Message��P� / �@ IsWaitingForData0 . ( �� .���� .��W� 5 . $
 0:0:2D�$ 0X�$6 Forever��$ 1X�$ (Effect).Opacity�$
 Base��. ��� $
$ Base�� �@J�Effect   $7 10Q�#8 �  $9 0Q�$: 0Q�P� / �@ IsWaitingForData0 .  . ��� $
$ Base�� Z�  �@J�Effect�� ;   RightWindowCommands; +  %MahApps.Metro.Controls.WindowCommands  .@��� -   $ RegistrarAgora��y��� *NotisRegistered+#4 [ .���� < �� Orientation$< 
Horizontal=�$y�Visible=�.+��� $��20��$��20������   �� = �� AncestorType$= ButtonL�$3 
Foreground�> J� OpacityMask> !� ? j� Stretch$
? Fill=�  appbar_cupcake@ !� Visual#@ [ �� $��4 0 0 0q�$��Center=�$��Registrar Agora!��
���  ��$
��Bold"�$��Segoe UI Semibold)�.���� -   A ��Name$A 
tabControl��$��10,0,0,0q���Z� .@��� $��Busca��$��0q�$��5��$��5��$��6,2,9,2q���Z� .��� -   $ GridTab1��$��0,0,0,-3q� �� $
��137* ��� $
��139* ��� $
��397* ��� $
��294* ��� $
��283* � ��%   &	       ��  �� $	��27* ��� $
��516* ��� $	��40* �.+�-	  'MahApps.Metro.Controls.MetroProgressBar	  $��0,0,0,11q�#���   B � Maximum$	B 100Q�C � Minimum$C 0Q�$��16��$��10��$��16(�$��2��D � IsIndeterminateD �� *getSearching+�� -   E ��Name$E google_page_img��$
��Fill=�$��13q�$��1��$��2��y��� *getSearching+#4 [ ���� *getsetImagem+$ OneWay=��� -   $E 
image_logo��$#��Resources/iconeDivulgador.jpg��$��13,120,13,129q�$��1��$��2��F �� StretchDirection$
F Both=�y��� *SearchBoxEnabled+#4 [ ��   LightBorderBrush#���  $��3q�G �� CornerRadius$G 8,8,8,8��$��	9,10,10,5q�$��1��$��2��H � UseLayoutRoundingH .  ._��� -   $E image��$
��None=��� -	   $ CancelarButton��$��Parar Busca��  SquareButtonStyle#���   . $��16(�$��32��$	��Top=�$	��500��$��34��$��1��$��
10,13,10,0q�$��Center=�$��1��$��0��$��5,5,5,6q�{��� *getSearching+�� -
   $ NovaBuscaButton��$��
Nova Busca��  AccentedSquareButtonStyle#��[  . $��16(�$��32��$	��Top=�$	��500��$��34��$��	0,13,10,0q�$��1��I K� ZIndex$I 1��$��0��$��5,5,5,6q�{��� *SearchBoxEnabled+�� -   J ��Name$J label��$��Label��$��2��$
��Left=�$��
202,18,0,0q�$��2��$	��Top=�$��16��$��38���� 
���   �$��1q�$��32��$��10,0,3,0q�$��2��$	��Top=�$��3��$G 8�����	#FFDEDDE8._��� -   $J label_numemails��K �� ContentStringFormat$K Emails Extraídos: {0}��$��14(�   ToggleSwitchHeaderFontFamily#���  $��-1q�$	��Top=�$��32��$��0q�#���  $
��Left=�$	��281������ $3 getNumTotalEmails���Z� �� 
���   �$��1q�$��32��$��2,0,10,0q�$��2��$	��Top=�$��4��$G 8�����	#FFDEDDE8._��� -   $J label2_numtelefones��$K Telefones Extraídos: {0}��$��14(�#���  $��-1,-1,-6,-1q�$	��Top=�$��32��$��0q�#���  $
��Left=�$	��276������ $3 getNumTotalPhones���Z� � $��69,200,68,200q�$��1��$��Center=�$	��141��$	��116��$��Center=�$��2��.+�)
  #MahApps.Metro.Controls.ProgressRing
  $��
26,1,38,49q�$
��Auto��$
��Auto��$��Stretch=�$��Stretch=�L 
  IsActiveL �� *getSearching+�� -   $J emprogresso��$��Em Progresso...��$��0,81,0,0q�$��17.333(�$��Segoe UI Semibold)�M J� RenderTransformOrigin$M 0.732,0.592&�y��� *getSearching+#4 [ �� -   N ��Name$N versionTextBox��$
��Left=�$��23��$��0,10,0,0q�$��2��O �� TextWrapping$
O Wrap=�$	��Top=�$	��120��$��0q�|�.  P �� 
IsReadOnlyP . Q � Cursor$Q Arrow��&   System.Windows.Controls.DataGrid  R   AutoGenerateColumnsR .    MetroDataGrid#��[ $��0q�$��
10,13,10,5q�$��3��$��1��$��2��
���   �$��0q����� *StatsModelCollection+��Z� ��Z� S   ColumnsS 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumnT   Header$T Título da Página��U   Width5  /System.Windows.Controls.DataGridLengthConverter$	U 220 1  +System.Windows.Controls.DataGridBoundColumnV   BindingV �� *
GetTitle+$ OneWay=�  $T Página��$U 70 V �� *GetPageNumber+$ OneWay=�  $T E-Mails��$U 70 V �� *GetEmailsCount+$ OneWay=�  $T 	Telefones��$U 90 V �� *GetPhonesCount+$ OneWay=��� #���  $��3��$��
10,10,10,5q�$��1��$��3q�$G 8��$��2���� $��Ver E-Mails��$��6,2,9,2q�.��� -   $ GridTab2��$��
0,16,-2,-5q� ��  �� .+�� $��
0,39,168,0q�.+��� -   W ��Name$W 
ListEmails��$��Disabled=�$
��Auto=�X �� SelectedIndex$X 0��$��0q�|�.  ���� *DataEmailCollection+��Z� ��Z� ��Z� z�V� .~��� �� �� Y �� Angle$Y -0.124Q�T� ���� .R�� Z � Orientation$Z Vertical=����� .R��� [ ��Name$[ 
checkBox33��$��Disabled=�$��5,0,0,0q�$��2,0,0,0q����� *	GetData+\ d� 	IsChecked\ �� *
IsSelected+$ TwoWay=��� -   $ exportarEmails��$��Exportar Emails��#��[  . $��16(�$��34��$	��Top=�$	��153��$��34��$��	0,51,15,0q�$��Right=�$	��153���� -   $N textboxEmails��]   UseFloatingWatermark] . $ 	Pesquisar��^   ClearTextButton^ .   MetroButtonTextBox#���  $��Center=�$��Segoe UI)�_ �� 	MaxLength$_ 80��` �� MaxLines$` 1��$	��3,0q�$	��270��$��37��$	��270��$��37��$��37��$	��Top=�$
��Left=�$	��270��a �� TextDecorationsa Z� �� -   $[ checkBox_selecionartudo1��  MetroCheckBox#��[ $��Selecionar Tudo��$��	0,90,15,0q�$	��Top=�$��27��$��Right=�$	��153��$��Segoe UI Semibold)�$��13.333(��� -   $ ExportarTudo2��$��Exportar Tudo��#��[  . $��16(�$��34��$	��Top=�$	��153��$��34��$��0,2,15,0q�$��Right=�$	��153���� $��Ver Telefones��.��� -   $ GridTab3��$��
0,16,-2,-5q� ��  �� .+�� $��
0,39,168,0q�.+��� -   $W 
ListPhones��$��Disabled=�$
��Auto=�$X 0��$��0q�|�.  ���� *DataPhoneCollection+��Z� ��Z� ��Z� z�V� .~��� �� �� $Y -0.124Q�T� ���� .R�� $Z Vertical=����� .R��� $[ checkBox��$��Disabled=�$	��5,0q�$��2,0,10,0q����� *	GetData+\ �� *
IsSelected+$ TwoWay=��� -   $ exportarPhones��$��Exportar Telefones��#��[  . $��16(�$��34��$	��Top=�$	��153��$��34��$��	0,51,15,0q�$��Right=�$	��153���� -   $N textboxPhones��] . $ 	Pesquisar��^ . #���  $��Center=�$��Segoe UI)�$_ 80��$` 1��$	��3,0q�$	��270��$��37��$	��270��$��37��$��37��$	��Top=�$
��Left=�$	��270��a Z� �� -   $[ checkBox_selecionartudo��#��[ $��Selecionar Tudo��$��	0,90,15,0q�$	��Top=�$��27��$��Right=�$	��153��$��Segoe UI Semibold)�$��13.333(��� -   $ exportarTudo��$��Exportar Tudo��#��[  . $��16(�$��34��$	��Top=�$	��153��$��34��$��0,2,15,0q�$��Right=�$	��153��b   Flyoutsb +  %MahApps.Metro.Controls.FlyoutsControl  .@�#  MahApps.Metro.Controls.Flyout  -   c  Name$c flyout��d   Header$d 
Nova Busca��e   Position$
e Left=�$	��400��.��� .+��� -   $N textbox_search��] .  $ 	Pesquisar��$_ 80��$` 1��$��0,0,3,0q�$��30��$	��Top=�#���  $��
10,20,19,0q�$��2��$��Segoe UI Semibold)�$��13.333(�{��� *SearchBoxEnabled+.��f   ButtonContentf �� $��20��$��20��#���   > !� $
? Fill=�  appbar_arrow_right#@ �  .��� $
��Left=�$��59��$��0,55,0,0q�$	��Top=�$	��380��$��2�� ��%   &	       �� .+�*  $MahApps.Metro.Controls.NumericUpDown  -   g  Name$g numeric_ini2��h   Minimum$h 1Q�i   Maximum$	i 100Q�j   Interval$j 1Q�$��
134,11,0,0q�$��33��$	��Top=�$M 1.853,1.369&�$
��Left=�$��81��k   Valuek �� *GetMinValuePag+$ TwoWay=�  -   $g numeric_end2��$	i 100Q�$j 1Q�$��
299,11,0,0q�$��33��$	��Top=�h �� *Value+l �� ElementName$l numeric_ini2��$ TwoWay=�k �� *GetMaxValuePag+$ TwoWay=��� -    $J label11��$	��De:��$
��Left=�$��	98,11,0,0q�$	��Top=�$��31��$��33��$��14.667(�$��Segoe UI Historic)��� -!   $J label22��$��Até:��$
��Left=�$��
259,11,0,0q�$	��Top=�$M 1.406,0.705&�$��14.667(�$��Segoe UI Historic)�$��33���� -"   $J label11_Copy��$��Normal"�   ToggleSwitchHeaderFontSize#���   #���  $
��Left=�$��
12,11,0,15q�$
 0.65Q�$��Center=�$��	Páginas:��$��74��$��33��&   System.Windows.Media.TextOptionsm   TextFormattingMode$m Display=�$M 1.027,0.667&�$��0,5,0,0q�)  #MahApps.Metro.Controls.ToggleSwitch  -#   n  Name$n toggleExternalUrls��o   Header$o Incluir URLs Externas��p   OnLabel$	p Sim��q   OffLabel$
q Não��$��10,69,0,-69q�$Q  ��H . $��0q�$
��Left=�$��Center=�$��Center=�r   	IsCheckedr �� *isExternalUrlBoxActive+$ OneWayToSource=��� -$   $N textBox_ExternalUrls��$# Insira uma URL/Link por linha��] . $
��Left=�$	��320��$��
10,195,0,0q�$	��Top=�$	��380��s �� AcceptsReturns . "t �� VerticalScrollBarVisibility$
t Auto=�y��� $l toggleExternalUrls��$3 	IsChecked�#4 [ 