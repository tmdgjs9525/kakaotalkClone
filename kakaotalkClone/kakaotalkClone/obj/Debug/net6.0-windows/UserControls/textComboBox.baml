   M S B A M L   `   `   `  ????I  EkakaotalkClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:kakaotalkClone.UserControlskakaotalkClone.UserControls  5      .    (kakaotalkClone.UserControls.textComboBox   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:kakaotalkClone.UserControls     5        ? 	Resources  5	         NormalBrush ?? 
StartPoint ?? EndPoint ? Color ? Offset  WindowBackgroundBrush ?? Color  ComboBoxToggleButton ?? 
TargetType ? ColumnDefinitions ??Name	 ?? CornerRadius
 F?Name  ComboBoxTextBox ?? 
TargetType ?? Property ?? Value ?? 	ClickMode d? 	IsChecked ?? Path ?? Mode ?? RelativeSource J? IsHitTestVisible ??Name ?? 
IsReadOnly ?? 
IsReadOnly ?? IsDropDownOpen ? AllowsTransparency J? SnapsToDevicePixels ? ActualWidth ?? MaxDropDownHeight K? IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation ?? Triggers??%?  &	        &	 ?     &	 ?     7   7  &	 v    '?? ?    7  7  7  ?? 5
   
   $	 0,0&?62   $	 0,1&?6C   ??5      ? ? 5      $ White??6#   $	 0.0Q?61   ? 5      $ White??6'   $	 1.0Q?65   5      5      ?? 5      $ White??6<   ?? 5      " d?6;   .R?5      ?  5      ?? 5      ?? 5      $??20 ?6+   .+?5      ?? $ Border??6   $??2??6-   $	 2??6A   8??  $??1q?5      ?? 5      $??0??5      $	 2,0,0,2??5       $??1q?5!      8?? $??0,0,1,0q?5#      F? 5$      $
 Arrow??6   $??1??6&   
???   ?$??Center=?6D   $??Center=?6a   "????        ? 	=  	= ? z     	6|   5%      5&      ?? 5(      " ??66   .R?5)      ?? $ PART_ContentHost??6   $|?False??63   #??z??6E   5*      ?? 5-      " ??6.   .?5.      ??  ? ?? 5/      ?? 50      " ??6*   .R?51      ? .+?52   "   d? $??ToggleButton??53   
   8??  $??2??55   
   $|?false??56   
   $ Press=?58   
    57   
   ?? $ IsDropDownOpen?$ TwoWay=? ?? *TemplatedParent+59   #   ?? 5:   "   $??ContentSite??5;   	   $ False??5<   	   $??3,3,23,3q?5=   	   $??Center=?5>   	   $
??Left=?5?   	   ?? 5@   "   $ PART_EditableTextBox??6*   8?? $
??Left=?5C   
   $??Center=?5D   
   $??3,3,23,3q?5E   
   $
|?True??5F   
   
?????? $y?Hidden=?5H   
   # z 5I   
   ??5A   
   Z? 5I   
   ? 5J   "   $??Popup??5K   	   $??Bottom=?5L   	   #??z 5M   	   $
 True??5N   	   $|?False??5O   	   $??Slide=?5P   	   .??5Q   &   ? $??DropDown??5R      $
 True??5S      #??z 5T      #??z 5U      .+?5V   *   ?? $ DropDownBorder??5W      8?? $??1q?5Y      ?? 5Z   *   $??4,6,4,6q?67   $
 True??6H   .??5[   .   ?? $
 True??69   $ 	Contained=?6L   5\   +   5]   '   5^   #   5_      5`      5b       5c      5e      5f      .??5g      ? .+?5h   
   ?? $??40??6   ??5i      ?? 5j      " ??6   .?5k      ??  ? ??
 ?????63   ?? 5l       ? ??
 ?????64   5m      .@?5o      ?? $??s??6   6)   5p      ?? 5q   
   $	??220??6   $??37??6   $??Center=?6+   $
??Left=?6M   
???????
???????6|   5r      5s      