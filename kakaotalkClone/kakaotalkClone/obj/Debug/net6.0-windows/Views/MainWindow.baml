   M S B A M L   `   `   `  ????I  EkakaotalkClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:kakaotalkClone.ViewskakaotalkClone.Views  5   	   %    kakaotalkClone.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   .local"clr-namespace:kakaotalkClone.Views  5   	     ? Title$  	KaKaoTalk??5	   	   $	??650??6   $	??450??6(    ? 	Resources 5
         smallBtn ?? 
TargetType ?? Property ?? Value  headerX??%$  &	        &	 ?     ?? 5   
   " ??6!   .?5      ??  ? ??$ 30??6&   63   ?? 5       ? ??$ 30??6'   64   ?? 5       ? ??
 ???? 6A   ?? 5       ? ??$ 0q?60   6<   5      ?? 5   
   " ??6    .?5      ??  ? ??$ 0??6'   63   5      5      .??5      ? .+?5   
   ?? ???#d2d2dd ?? Orientation$ Vertical=?6*   $??80??6A   $
??Left=?6L   .+?5      ?? $??40??6   $??40??6    
?????? $??0q?6E   $??Center=?6Y   $??0,50,0,0q?6v    ? ToolTip$ 친구??6?   .??5      ?? $ ??/Resources/friendSmall.png??6   6?   5      5      ]? 5   
   $??50??6   $	??Top=?6!   $??0,30,0,0q?69   .+?5      ?? #???   6   $
??Left=?69   $??	310,0,0,0q?6T   $ 통합검색??6g   .??5      ?? $??/Resources/search.png??6   69   5      ?? 5       #???   6   $
??Left=?68   $??0,0,0,0q?6S   $ 통합검색??6d   .??5!      ?? $??/Resources/openChat.png??6   6;   5"      ?? 5#      #???   6   $
??Left=?68   $??0,0,0,0q?6S   $ 통합검색??6d   .??5$      ?? $??/Resources/addRoom.png??6   6:   5%      5&      ]? 5'   
   $	??353??6   $	??540??6    $??Bottom=?6-   $??Right=?6H   .+?5(      ?? $??0q?6=    ?? SelectedItem 6   ?? *SelectedItem+??6Q   ?? *Rooms+ ?? View 5)      ?? 5*      .P?5+      ?? 	 ?? HeaderContainerStyle#	 ?  6)   $??	프로필??6Z   
 ?? Width$
 70??6g    ?? CellTemplate 5,      ?? 5-   "   .R?5.   &   ?? $??60??6,   $??60??67   ??6C   ?? *User.UserImg+5/   #   51      ?? 52      #	 ?  6)   $??내용??6Z   $	
 280??6f    53      ?? 54   "   .R?55   &   ]? $	??150??60   .+?56   *   ?? 
???????61   ?? 57   *   $??2,0,0,1q?58   -   $
??Left=?59   -   $	??Top=?5:   -   $??18(?5;   -   ??5<   -   ?? *User.UserName+?? 5=   6   $??2,0,0,1q?5>   -   $
??Left=?5?   -   $??13(?5@   -   ??5A   -   ?? *
LastText+5B   '   5C   #   5E      5F      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5H      +  %Microsoft.Xaml.Behaviors.EventTrigger  5I         	EventName$ MouseDoubleClick??6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5J      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 60   ?? *roomDoubleClick+6V   5K      5M      5N      5O      5P      