   M S B A M L   `   `   `  ����G  CMessageCoder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MessageCoderMessageCoder  5   	       MessageCoder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MessageCoder     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��1q�6   
���   �._�5      �� -   5         ��Name$ 
MessageBox��5      $��Enter Message Here��6*   $
��Left=�6E   $��63.2,76.2,0,0q�6`    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $��91��6�   $	��299��6�    J� RenderTransformOrigin$ 0.512,0.524&�6�   5      �� 5   
   -   5        $ ScrambleNumBox��5      $
��Left=�6*   $��23��6E   $
 Wrap=�6Q   $��##��6e   $	��Top=�6o   $	��120��6�   $��188,190,0,0q�6�   �� 5   
   $��Enter Code Number:��6   $
��Left=�6-   $	��Top=�6H   $��
63,186,0,0q�6`   $	��120��6t   �� 5   
   -   5        $��Encrypt/Decrypt��5      $
��Left=�6@   $	��Top=�6[   $	��120��6s   $��127,241,0,0q�6   �� 5   
   -   5        $ 	ResultBox��5      $
��Left=�6&   $��98��6A   $
 Wrap=�6M   $��Result��6a   $	��Top=�6o   $	��289��6�   $��
432,77,0,0q�6�   �� 5   
   $��Scrambled Message:��6   $
��Left=�6-   $	��Top=�6H   $��
432,28,0,0q�6`   $	��124��6t   �� 5   
   $��Initial Message:��6   $
��Left=�6+   $	��Top=�6F   $��	63,28,0,0q�6^   $��98��6q   �� 5   
   -   5         ��Name$ ResetButton��5      $��Reset��6&   $
��Left=�6L   $	��Top=�6g   $��75��6   $��151,289,0,0q�6�   5      5      