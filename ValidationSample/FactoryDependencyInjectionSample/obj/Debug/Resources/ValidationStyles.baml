   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   validationTooltip  �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self �� RelativeSource �� Path  asterisk	 �� BasedOn
 � ToolTip �� ElementName  overlay 	 excel � Points ��Name  exceloverlay  ErrorGradient � Color � Offset  popuptemplate ��Name J� IsHitTestVisible � AllowsTransparency � HorizontalOffset � VerticalOffset � PlacementTarget �� Orientation �� Stretch �� CornerRadius �� Padding �� Mode�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 �     7   &	 �    7   &	 |    7   &	 �    7   &	 5
    &	 �
    7  �� 5      "  ��6&    5   
   P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5	      �� # Z $) #(Validation.Errors)[0].ErrorContent�5      5      �� 5      "  ��6   8	   .�5   
   ��  �@=�ErrorTemplate 5      �� 5      .R�5      � 
 6   �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�.+�5      �� 
���  ��$
��16pt(�65   $��Right=�6E   $��Center=�6a   $��0,0,10,0q�5      $
��Bold"�6*   *6?   �� 5      
���  ��$��1q�63   $��6q�6G   
 5      �� # Z $) #(Validation.Errors)[0].ErrorContent�._�5      �� $��customAdorner��68   5      5      5      5      5       �� 5%      "  ��6   8	   .�5&   
   ��  �@=�ErrorTemplate 5'      �� 5(      .R�5)      � 
 6   �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�.+�5*      �� 
���  ��$
��16pt(�65   $��Right=�6E   $��Center=�6a   $��0,0,10,0q�5+      $
��Bold"�6*   *6?   �� 5,      
���  ��$��1q�63   $��6q�6G   
 5-      �� # Z $) #(Validation.Errors)[0].ErrorContent�._�5/      �� $��customAdorner��68   50      51      52      54       55   
   P� 56       �@=�HasError . . �57      ��  � ��
 �����67   �� 58       � ��
 �   �67   59      5;      �� 5?      "  ��6   8	   .�5@   
   ��  �@=�ErrorTemplate 5A      �� 5B      .R�5C      � .+�5D      � ' �    -1���  -1�� �� �� 
���  ��$��1��5F      
���  ��$��Right=�5H      $	��Top=�5I      
 5J      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent��� 5L      
���  ��$��1q�63   
 5M      �� # Z $) #(Validation.Errors)[0].ErrorContent�._�5O      �� $ customAdorner��68   5P      5Q      5R      5T      5U      �� 5Z      "  ��6   8	   .�5[   
   ��  �@=�ErrorTemplate 5\      �� 5]      .R�5^      � .+�5_      � ' �    -1���  -1�� �� �� 
���  ��$��1��5a      
���  ��$��Right=�5c      $	��Top=�5d      
 5e      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent��� 5g      
���  ��$��1q�63   
 5h      �� # Z $) #(Validation.Errors)[0].ErrorContent�._�5k      �� $ customAdorner��68   5l      5m      5n      5p       5q   
   P� 5r       �@=�HasError . . �5s      ��  � ��
 �����67   �� 5t       � ��
 �   �67   5u      5w      �� 5x      .��5y   
   � $
 Pink��6   $ 0Q�6$   � 5z   
   $	 red��6   $ .4Q�6#   5{      �� 5|      "  ��6   .�5}   
   ��  �@=�ErrorTemplate 5~      �� 5      .R�5�      � .+�5�      �� $ errorBorder��6f   ���	#FFCB2E2E$��1q�69    .  6f   �� 5�      $ placeholder��64   � 5�       . $��Right=�6:   $ 5��6V   $ 0��6k   $
��Fade=�6~   $��Right=�5�   "   ��.  64   �� $ errorBorder��.��5�      �� $ 
Horizontal=�6)   .+�5�   "   � $��Center=�6+    �   ��- ��- ��- ��[ ���	#FFCB2E2E$
 Fill=�6l   ���	#FFCB2E2E$��2��5�   '   �� 5�   "   8��  $ 4��6U   $ 4q�6f   ._�5�   &   �� $��Center=�60   
�������$
��Bold"�6`   $��2,0,0,0q�6r   ��5�   4   �� $ placeholder��$ AdornedElement.ToolTip�$ OneWay=�5�   #   5�      5�      5�      5�      5�       5�   
   P� 5�       �@=�HasError . . �5�      ��  �@�ToolTip 6,   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5�      5�      5�      