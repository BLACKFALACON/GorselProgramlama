   M S B A M L   `   `   `  ����C  ?HaliSaha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HaliSahaHaliSaha  5   	       HaliSaha.SahaEkle   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HaliSaha     5   	     � Title$  SahaEkle��5   	   $	��450��6   $	��600��6'   .��5	      � $��	0,0,0,0.5q�6   ��5
   
   �� 5       �� ImageSource$� �https://lh3.googleusercontent.com/proxy/HfVG9_TCsAiq3UrbdF5vrCRtAmHkq2H32NupUUOMVYnxOgXAFbK_YDYM88IgnorcgVQBbOyd0pU6du1uIN8kndZL5GBpGORhooskAiAGt5xlX5kndYnLRDBG��6    j� Stretch$ UniformToFill=�6�   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgsaha��5      $
��Left=�6!      AutoGenerateColumns .  $	��185��6X   $��	43,80,0,0q�6e   $	��Top=�6x   $	��505��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SAHA ID��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+6<     5      $ SAHA ADI��6A    6%   �� *
sahaAdı+6A     5      $ FİYAT��6?    6%   �� *fiyat+6?     5      $ KONUM��6?    6%   �� *konum+6?     5      $ 	KAPASİTE��6B    6%   �� *
kapasite+6B   5      �� 5   
   -   5        $��	txtsahaad��5      $
��Left=�6#   $��23��6>   $��112,291,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��txtsahafiyat��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   $��112,319,0,0q�6�   �� 5   
   -   5        $��txtsahakapasite��5      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   $��112,347,0,0q�6�   �� 5   
   -   5         ��Name$ txtsahakonum��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $	��120��6�   $��112,375,0,0q�6�   �� 5   
   -   5        $��Kaydet��5      $��Right=�6"   $��0,289,269,0q�6>   $��63��6S   	 J� RenderTransformOrigin$	 3.944,0.281&�6r   $	��106��6�   $	��Top=�6�   �� 5   
   -   5        $	��Sil��5      $��Right=�6   $��36��6;   $��0,355,122,0q�6G   $	��Top=�6\   $	��120��6t   $	 0.606,2.595&�6�   �� 5   
   -   5        $ 	txtsahaid��5      $��Right=�6%   $��23��6A   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   $��0,323,122,0q�6�   �� 5   
   $��	Saha Adı��6   $
��Left=�6#   $��
42,291,0,0q�6>   $	��Top=�6R   �� 5   
   $��
Saha Fiyat��6   $
��Left=�6%   $��
42,319,0,0q�6@   $	��Top=�6T   �� 5   
   $��Saha Kapasite��6   $
��Left=�6(   $��
20,347,0,0q�6C   $	��Top=�6W   �� 5    
   $��
Saha Konum��6   $
��Left=�6%   $��
26,372,0,0q�6@   $	��Top=�6T   �� 5!   
   $��Saha Id��6   $
��Left=�6"   $��385,292,0,0q�6=   $	��Top=�6R   �� 5"   
   $��	Saha Ekle��6   $��45(�6$   $
��Left=�62   $��
204,10,0,0q�6M   $	��Top=�6a   �� 5#   
   -	   5        $��ANASAYFA��5#      $��Right=�6$   $��96��6@   $��
0,299,17,0q�6L   $	��Top=�6`   $��82��6x   $	 0.606,2.595&�6�   5'      5(      