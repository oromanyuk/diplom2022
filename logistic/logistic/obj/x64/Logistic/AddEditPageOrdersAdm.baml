   M S B A M L   `   `   `  ���� C  ?logistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:logisticlogistic  #    logistic.AddEditPageOrdersAdm   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:logistic       N� Title$  AddEditPageOrdersAdm��.��� .+��� $��Водитель��$��Center=��� $��Клиент��$��Center=�$��1���� $��Транспорт��$��Center=�$��2���� $��Размер Груза��$��Center=�$��3���� $)��#Протяжённость пути��$��Center=�$��4���� $%��Пункт назначения��$��Center=�$��5���� $��Цена��$��Center=�$��6���� $��Тип груза��$��Center=�$��7���� $��Дата поездки��$��Center=�$��8���� $��Статус��$��Center=�$��9���� -   $��Combo_drivers_Adm��$��1��$��25��$	��175��$
��Left=� �� DisplayMemberPath$	 FIO�� �� SelectedItem �� *	drivers+�� -   $��Combo_client_Adm��$��1��$��1��$��25��$	��175��$
��Left=�$	 FIO�� �� *	clients+�� -   $��Combo_transport_Adm��$��2��$��1��$��25��$	��175��$
��Left=�$ 
reg_number�� �� *	transport+�� -   $��BoxCargoSizeAdm��$��3��$��1��$	��175��$��25��$
��Left=����� *
cargo_size+�� -   $��BoxLenghtPathAdm��$��4��$��1��$	��175��$��25��$
��Left=����� *lenght_path+�� -   $��BoxDestiAdm��$��5��$��1��$	��175��$��25��$
��Left=����� *destination+�� -   $��BoxPriceAdm��$��6��$��1��$	��175��$��25��$
��Left=����� *price+�� -   $��BoxCargoTypeAdm��$��7��$��1��$	��175��$��25��$
��Left=����� *
cargo_type+�� -	   $��
BoxDateAdm��$��8��$��1��$	��175��$��25��$
��Left=����� *date+�� -
   $��Combo_status_adm��$��9��$��1��$��25��$	��175��$
��Left=�$ status_name�� �� *status_orders+�� -    ��Name$ Btn_Save_Orders_Adm��$��Сохранить��$��10��$��Center=�$��Center=�$��1��$��75.4,5.6,300,5.2q� � RowDefinitions �� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 � � ColumnDefinitions �� $	��250 ��� $��* �