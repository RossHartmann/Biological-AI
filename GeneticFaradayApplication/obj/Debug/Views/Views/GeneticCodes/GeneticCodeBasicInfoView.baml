   M S B A M L   `   `   `  ����  GeneticFaradayApplicationQ    KGeneticFaradayApplication.Views.Views.GeneticCodes.GeneticCodeBasicInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $	��407��5      $	��201��6,   .��5      � .+�5   
   �� -   5          ��Name$  codon_length_text_box��5   -   $
��Left=�6   $��23��6M   $��0,76,0,0q�6Y    �� TextWrapping$
 Wrap=�6k   $��6��6   $	��Top=�6�   $	��199��6�    � ToolTip$W QThe length of every Codon in the Genetic Code. All Codons must be of this length.��6�   �� 5	   
   $��Codon Length��6   $
��Left=�6'   $��0,50,0,0q�6B   $	��Top=�6T    J� RenderTransformOrigin$ 0.158,-0.423&�6l    J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 7Q�6#      Opacity$	 0.9Q�62   5      �� 5   
   -   5        $0  *max_parameterful_functions_in_dna_text_box��5   -   $
��Left=�6   $��23��6b   $��	0,125,0,0q�6n   $
 Wrap=�6�   $��10��6�   $	��Top=�6�   $	��199��6�   $� �The maximum number of Functions that take parameters that can be used in an Allele's IDNA. After (or before) this number of Functions (with parameters) have been called, the rest of the Functions in the IDNA will not accept any parameters (i.e. they  will be terminals).��6�   �� 5   
   $'��!Max Parameterful Functions In DNA��6   $
��Left=�6<   $��0,99,0,0q�6W   $	��Top=�6i   $ 0.158,-0.423&�6�    5        5      $ 7Q�6#   $	 0.9Q�62   5      �� 5   
   -   5        $"  max_recursion_level_text_box��5   -   $
��Left=�6   $��23��6T   $��	0,175,0,0q�6`   $
 Wrap=�6s   $��3��6�   $	��Top=�6�   $	��199��6�   $� �The maximum recursion level that's allowable. If this value is reached by an IGEPGene, the execution of the IGEPGene will be aborted.��6�   �� 5   
   $��Max Recursion Level��6   $
��Left=�6.   $��	0,149,0,0q�6I   $	��Top=�6\   $ 0.158,-0.423&�6t    5        5      $ 7Q�6#   $	 0.9Q�62   5      �� 5   
   $	��DNA��6   $
��Left=�6    $��0,203,0,-105q�6;   $	��Top=�6Q   $	��202��6i   $	��199��6v    5        5      $ 8Q�6#   $	 0.5Q�62   5      �� 5   
   -   5        $  dna_tail_length_text_box��5   -   $
��Left=�6   $��23��6O   $��
11,252,0,0q�6[   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��179��6�   $� ~The Length of the tail of a sequence of IDNA as measured in INucleotides. The tail can only use IFunctions without Parameters.��6�   {�.  68  �� 5    
   $��Tail Length��6   $
��Left=�6&   $��
11,221,0,0q�6A   $	��Top=�6U   $ 0.158,-0.423&�6m    5!        5"      $ 7Q�6#   $	 0.9Q�62   5$      �� 5%   
   -   5        $  dna_head_length_text_box��5%   -   $
��Left=�6   $��23��6O   $��11,306,0,-29q�6[   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��179��6�   $� �The Length of the head of a sequence of IDNA as measured in INucleotides. The head can use IFunctions with or without Parameters.��6�   {�.  6=  �� 5&   
   $��Head Length��6   $
��Left=�6&   $��11,275,0,-1q�6A   $	��Top=�6V   $ 0.158,-0.423&�6n    5'        5(      $ 7Q�6#   $	 0.9Q�62   5*      �� 5+   
   -   5        $  dna_total_length_text_box��5+   -   $
��Left=�6   $��23��6P   $��11,360,0,-83q�6\   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��179��6�   $ The length of all IDNA.��6�   {�.  6�   �� 5,   
   $��Total Length��6   $
��Left=�6'   $��11,329,0,-55q�6B   $	��Top=�6X   $ 0.158,-0.423&�6p    5-        5.      $ 7Q�6#   $	 0.9Q�62   50      �� 51   
   -   5        $   genetic_code_name_text_box��51   -   $
��Left=�6   $��23��6R   $��0,26,0,0q�6^   $
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��199��6�   $* $The unique name of the Genetic Code.��6�   �� 52   
   $��Genetic Code Name��6   $
��Left=�6,   $	��Top=�6G   $ 0.158,-0.423&�6_    53        54      $ 7Q�6#   $	 0.9Q�62   56      58      59      