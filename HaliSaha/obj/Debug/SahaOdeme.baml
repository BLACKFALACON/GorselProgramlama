   M S B A M L   `   `   `  ����C  ?HaliSaha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HaliSahaHaliSaha  5   	       HaliSaha.SahaOdeme   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HaliSaha     5   	     � Title$  	SahaOdeme��5   	   $	��450��6   $	��600��6(   .��5	      � ��5
   
   �� 5       �� ImageSource$� �https://lh3.googleusercontent.com/proxy/HfVG9_TCsAiq3UrbdF5vrCRtAmHkq2H32NupUUOMVYnxOgXAFbK_YDYM88IgnorcgVQBbOyd0pU6du1uIN8kndZL5GBpGORhooskAiAGt5xlX5kndYnLRDBG��6    j� Stretch$ UniformToFill=�6�   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgsaha��5         AutoGenerateColumns .  $	��185��6=   $��	43,80,0,0q�6J   $	��Top=�6]   $
��Left=�6v   $	��505��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SAHA REZARVASYON ID��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6<     5      $ SAHA ID��6@    6%   �� *SahaId+6@     5      $ TARİH��6?    6%   �� *Tarih+6?     5      $
 SAAT��6>    6%   �� *Saat+6>     5      $	 NOT��6>    6%   �� *Nott+6>     5      $ DURUM��6?    6%   �� *Durum+6?   5      �� 5   
   $��Saha Ödeme��6   $��45(�6%   $
��Left=�63   $��
177,10,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $	��Ode��5      $��Right=�6   $��36��6;   $��0,356,259,0q�6G   $	��Top=�6\   $	��191��6t    J� RenderTransformOrigin$ 0.606,2.595&�6�   �� 5   
   -   5         ��Name$ txtsaharezid��5      $��Right=�6(   $��23��6D   	 �� TextWrapping$
	 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   $��0,312,380,0q�6�   �� 5   
   $��Saha Rezarvasyon Id��6   $
��Left=�6.   $��
98,282,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $��ANASAYFA��5      $��Right=�6$   $��96��6@   $��
0,294,97,0q�6L   $	��Top=�6`   $��82��6x   $ 0.606,2.595&�6�   �� 5   
   -   5        $ 	txtsahaid��5      $��Right=�6%   $��23��6A   $
	 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   $��0,312,222,0q�6�   �� 5   
   $��Saha  Id��6   $
��Left=�6#   $��256,282,0,0q�6>   $	��Top=�6S   5"      5#      