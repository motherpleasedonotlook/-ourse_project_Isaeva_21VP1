<a name='assembly'></a>
# Сourse_project_Isaeva_21VP1

## Contents

- [AddingForm](#T-Сourse_project_Isaeva_21VP1-AddingForm 'Сourse_project_Isaeva_21VP1.AddingForm')
  - [#ctor(form2,item)](#M-Сourse_project_Isaeva_21VP1-AddingForm-#ctor-Сourse_project_Isaeva_21VP1-TheMainForm,Сourse_project_Isaeva_21VP1-Item- 'Сourse_project_Isaeva_21VP1.AddingForm.#ctor(Сourse_project_Isaeva_21VP1.TheMainForm,Сourse_project_Isaeva_21VP1.Item)')
  - [components](#F-Сourse_project_Isaeva_21VP1-AddingForm-components 'Сourse_project_Isaeva_21VP1.AddingForm.components')
  - [Dispose(disposing)](#M-Сourse_project_Isaeva_21VP1-AddingForm-Dispose-System-Boolean- 'Сourse_project_Isaeva_21VP1.AddingForm.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-Сourse_project_Isaeva_21VP1-AddingForm-InitializeComponent 'Сourse_project_Isaeva_21VP1.AddingForm.InitializeComponent')
- [DBClass](#T-Сourse_project_Isaeva_21VP1-DBClass 'Сourse_project_Isaeva_21VP1.DBClass')
  - [#ctor()](#M-Сourse_project_Isaeva_21VP1-DBClass-#ctor 'Сourse_project_Isaeva_21VP1.DBClass.#ctor')
  - [name](#F-Сourse_project_Isaeva_21VP1-DBClass-name 'Сourse_project_Isaeva_21VP1.DBClass.name')
  - [DBToFile(stream)](#M-Сourse_project_Isaeva_21VP1-DBClass-DBToFile-System-IO-Stream- 'Сourse_project_Isaeva_21VP1.DBClass.DBToFile(System.IO.Stream)')
  - [DBToList()](#M-Сourse_project_Isaeva_21VP1-DBClass-DBToList 'Сourse_project_Isaeva_21VP1.DBClass.DBToList')
  - [addNote(item)](#M-Сourse_project_Isaeva_21VP1-DBClass-addNote-Сourse_project_Isaeva_21VP1-Item- 'Сourse_project_Isaeva_21VP1.DBClass.addNote(Сourse_project_Isaeva_21VP1.Item)')
  - [createComand(comand)](#M-Сourse_project_Isaeva_21VP1-DBClass-createComand-System-String- 'Сourse_project_Isaeva_21VP1.DBClass.createComand(System.String)')
  - [createDB()](#M-Сourse_project_Isaeva_21VP1-DBClass-createDB 'Сourse_project_Isaeva_21VP1.DBClass.createDB')
  - [dropDB()](#M-Сourse_project_Isaeva_21VP1-DBClass-dropDB 'Сourse_project_Isaeva_21VP1.DBClass.dropDB')
  - [editNote(id,quantity,prod,exp)](#M-Сourse_project_Isaeva_21VP1-DBClass-editNote-System-Int32,System-Int32,System-DateTime,System-DateTime- 'Сourse_project_Isaeva_21VP1.DBClass.editNote(System.Int32,System.Int32,System.DateTime,System.DateTime)')
  - [findNoteByID(id)](#M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByID-System-Int32- 'Сourse_project_Isaeva_21VP1.DBClass.findNoteByID(System.Int32)')
  - [findNoteByName(quantity)](#M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByName-System-Int32- 'Сourse_project_Isaeva_21VP1.DBClass.findNoteByName(System.Int32)')
  - [findNoteByName(name_)](#M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByName-System-String- 'Сourse_project_Isaeva_21VP1.DBClass.findNoteByName(System.String)')
  - [openDB(existing_db)](#M-Сourse_project_Isaeva_21VP1-DBClass-openDB-System-String- 'Сourse_project_Isaeva_21VP1.DBClass.openDB(System.String)')
  - [readQuery(myCommand)](#M-Сourse_project_Isaeva_21VP1-DBClass-readQuery-MySql-Data-MySqlClient-MySqlCommand- 'Сourse_project_Isaeva_21VP1.DBClass.readQuery(MySql.Data.MySqlClient.MySqlCommand)')
  - [removeNote(id)](#M-Сourse_project_Isaeva_21VP1-DBClass-removeNote-System-Int32- 'Сourse_project_Isaeva_21VP1.DBClass.removeNote(System.Int32)')
  - [sort(field,direction)](#M-Сourse_project_Isaeva_21VP1-DBClass-sort-System-String,System-String- 'Сourse_project_Isaeva_21VP1.DBClass.sort(System.String,System.String)')
- [EditingForm](#T-Сourse_project_Isaeva_21VP1-EditingForm 'Сourse_project_Isaeva_21VP1.EditingForm')
  - [#ctor(form2,item)](#M-Сourse_project_Isaeva_21VP1-EditingForm-#ctor-Сourse_project_Isaeva_21VP1-TheMainForm,Сourse_project_Isaeva_21VP1-Item- 'Сourse_project_Isaeva_21VP1.EditingForm.#ctor(Сourse_project_Isaeva_21VP1.TheMainForm,Сourse_project_Isaeva_21VP1.Item)')
  - [components](#F-Сourse_project_Isaeva_21VP1-EditingForm-components 'Сourse_project_Isaeva_21VP1.EditingForm.components')
  - [Dispose(disposing)](#M-Сourse_project_Isaeva_21VP1-EditingForm-Dispose-System-Boolean- 'Сourse_project_Isaeva_21VP1.EditingForm.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-Сourse_project_Isaeva_21VP1-EditingForm-InitializeComponent 'Сourse_project_Isaeva_21VP1.EditingForm.InitializeComponent')
- [Item](#T-Сourse_project_Isaeva_21VP1-Item 'Сourse_project_Isaeva_21VP1.Item')
  - [#ctor()](#M-Сourse_project_Isaeva_21VP1-Item-#ctor 'Сourse_project_Isaeva_21VP1.Item.#ctor')
  - [#ctor(id,name,productionDate,expirationDate,quantity)](#M-Сourse_project_Isaeva_21VP1-Item-#ctor-System-Int32,System-String,System-DateTime,System-DateTime,System-Int32- 'Сourse_project_Isaeva_21VP1.Item.#ctor(System.Int32,System.String,System.DateTime,System.DateTime,System.Int32)')
  - [count](#F-Сourse_project_Isaeva_21VP1-Item-count 'Сourse_project_Isaeva_21VP1.Item.count')
  - [expirationDate](#F-Сourse_project_Isaeva_21VP1-Item-expirationDate 'Сourse_project_Isaeva_21VP1.Item.expirationDate')
  - [id](#F-Сourse_project_Isaeva_21VP1-Item-id 'Сourse_project_Isaeva_21VP1.Item.id')
  - [name](#F-Сourse_project_Isaeva_21VP1-Item-name 'Сourse_project_Isaeva_21VP1.Item.name')
  - [productionDate](#F-Сourse_project_Isaeva_21VP1-Item-productionDate 'Сourse_project_Isaeva_21VP1.Item.productionDate')
  - [quantity](#F-Сourse_project_Isaeva_21VP1-Item-quantity 'Сourse_project_Isaeva_21VP1.Item.quantity')
  - [ToString()](#M-Сourse_project_Isaeva_21VP1-Item-ToString 'Сourse_project_Isaeva_21VP1.Item.ToString')
- [Program](#T-Сourse_project_Isaeva_21VP1-Program 'Сourse_project_Isaeva_21VP1.Program')
  - [Main()](#M-Сourse_project_Isaeva_21VP1-Program-Main 'Сourse_project_Isaeva_21VP1.Program.Main')
- [Resources](#T-Сourse_project_Isaeva_21VP1-Properties-Resources 'Сourse_project_Isaeva_21VP1.Properties.Resources')
  - [Culture](#P-Сourse_project_Isaeva_21VP1-Properties-Resources-Culture 'Сourse_project_Isaeva_21VP1.Properties.Resources.Culture')
  - [ResourceManager](#P-Сourse_project_Isaeva_21VP1-Properties-Resources-ResourceManager 'Сourse_project_Isaeva_21VP1.Properties.Resources.ResourceManager')
- [StartingForm](#T-Сourse_project_Isaeva_21VP1-StartingForm 'Сourse_project_Isaeva_21VP1.StartingForm')
  - [#ctor()](#M-Сourse_project_Isaeva_21VP1-StartingForm-#ctor 'Сourse_project_Isaeva_21VP1.StartingForm.#ctor')
  - [components](#F-Сourse_project_Isaeva_21VP1-StartingForm-components 'Сourse_project_Isaeva_21VP1.StartingForm.components')
  - [BlockCreating(value)](#M-Сourse_project_Isaeva_21VP1-StartingForm-BlockCreating-System-Boolean- 'Сourse_project_Isaeva_21VP1.StartingForm.BlockCreating(System.Boolean)')
  - [Dispose(disposing)](#M-Сourse_project_Isaeva_21VP1-StartingForm-Dispose-System-Boolean- 'Сourse_project_Isaeva_21VP1.StartingForm.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-Сourse_project_Isaeva_21VP1-StartingForm-InitializeComponent 'Сourse_project_Isaeva_21VP1.StartingForm.InitializeComponent')
- [TheMainForm](#T-Сourse_project_Isaeva_21VP1-TheMainForm 'Сourse_project_Isaeva_21VP1.TheMainForm')
  - [#ctor(form1,db)](#M-Сourse_project_Isaeva_21VP1-TheMainForm-#ctor-Сourse_project_Isaeva_21VP1-StartingForm,Сourse_project_Isaeva_21VP1-DBClass- 'Сourse_project_Isaeva_21VP1.TheMainForm.#ctor(Сourse_project_Isaeva_21VP1.StartingForm,Сourse_project_Isaeva_21VP1.DBClass)')
  - [components](#F-Сourse_project_Isaeva_21VP1-TheMainForm-components 'Сourse_project_Isaeva_21VP1.TheMainForm.components')
  - [db](#F-Сourse_project_Isaeva_21VP1-TheMainForm-db 'Сourse_project_Isaeva_21VP1.TheMainForm.db')
  - [AddToDB(item)](#M-Сourse_project_Isaeva_21VP1-TheMainForm-AddToDB-Сourse_project_Isaeva_21VP1-Item- 'Сourse_project_Isaeva_21VP1.TheMainForm.AddToDB(Сourse_project_Isaeva_21VP1.Item)')
  - [Dispose(disposing)](#M-Сourse_project_Isaeva_21VP1-TheMainForm-Dispose-System-Boolean- 'Сourse_project_Isaeva_21VP1.TheMainForm.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-Сourse_project_Isaeva_21VP1-TheMainForm-InitializeComponent 'Сourse_project_Isaeva_21VP1.TheMainForm.InitializeComponent')
  - [updateTable(list)](#M-Сourse_project_Isaeva_21VP1-TheMainForm-updateTable-System-Collections-Generic-List{Сourse_project_Isaeva_21VP1-Item}- 'Сourse_project_Isaeva_21VP1.TheMainForm.updateTable(System.Collections.Generic.List{Сourse_project_Isaeva_21VP1.Item})')

<a name='T-Сourse_project_Isaeva_21VP1-AddingForm'></a>
## AddingForm `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Форма добавления элемента

<a name='M-Сourse_project_Isaeva_21VP1-AddingForm-#ctor-Сourse_project_Isaeva_21VP1-TheMainForm,Сourse_project_Isaeva_21VP1-Item-'></a>
### #ctor(form2,item) `constructor`

##### Summary

Конструктор формы

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form2 | [Сourse_project_Isaeva_21VP1.TheMainForm](#T-Сourse_project_Isaeva_21VP1-TheMainForm 'Сourse_project_Isaeva_21VP1.TheMainForm') | объект класса TheMainForm - основной формы |
| item | [Сourse_project_Isaeva_21VP1.Item](#T-Сourse_project_Isaeva_21VP1-Item 'Сourse_project_Isaeva_21VP1.Item') | объект класса Item - добавляемый элемент |

<a name='F-Сourse_project_Isaeva_21VP1-AddingForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-Сourse_project_Isaeva_21VP1-AddingForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-Сourse_project_Isaeva_21VP1-AddingForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-Сourse_project_Isaeva_21VP1-DBClass'></a>
## DBClass `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Класс DBClass предназначен для связи и работы с базой данный MySQL

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-#ctor'></a>
### #ctor() `constructor`

##### Summary

DBClass – конструктор объекта класса. Присваивает полям имени базы и данных для соединения с MySQL значения по умолчанию

##### Parameters

This constructor has no parameters.

<a name='F-Сourse_project_Isaeva_21VP1-DBClass-name'></a>
### name `constants`

##### Summary

name - имя базы данных, задается пользователем. По умолчанию base_name

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-DBToFile-System-IO-Stream-'></a>
### DBToFile(stream) `method`

##### Summary

DBToFile - производит запись базы данных в файл

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | принимает объект класса Stream |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-DBToList'></a>
### DBToList() `method`

##### Summary

DBToList – преобразует базу данных в список List элементов типа Item.

##### Returns

возвращает список элементов типа Item

##### Parameters

This method has no parameters.

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-addNote-Сourse_project_Isaeva_21VP1-Item-'></a>
### addNote(item) `method`

##### Summary

addNote – выполняет команду SQL, которая добавляет запись в таблицу базы данных

##### Returns

возвращает true в случае успеха, false в случае неудачи

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [Сourse_project_Isaeva_21VP1.Item](#T-Сourse_project_Isaeva_21VP1-Item 'Сourse_project_Isaeva_21VP1.Item') |  |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-createComand-System-String-'></a>
### createComand(comand) `method`

##### Summary

создает объект команды к MySQL.

##### Returns

возвращает объект команды к MySQL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comand | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-createDB'></a>
### createDB() `method`

##### Summary

createDB – выполняет команду SQL, которая создает базу данных.

##### Returns

возвращает true в случае успеха, false в случае неудачи

##### Parameters

This method has no parameters.

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-dropDB'></a>
### dropDB() `method`

##### Summary

dropDB – выполняет команду SQL, которая удаляет базу данных

##### Returns

возвращает true в случае успеха, false в случае неудачи

##### Parameters

This method has no parameters.

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-editNote-System-Int32,System-Int32,System-DateTime,System-DateTime-'></a>
### editNote(id,quantity,prod,exp) `method`

##### Summary

editNote – выполняет команду SQL, которая обновляет запись о продукте.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID элемента - целое число |
| quantity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | новое значение количества продукта |
| prod | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | новое значение даты производства продукта |
| exp | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | новое значение даты истечения срока годности продукта |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByID-System-Int32-'></a>
### findNoteByID(id) `method`

##### Summary

findNoteByID – выполняет команду SQL, которая осуществляет поиск элемента по ID.

##### Returns

возвращает список List элементов типа Item

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID элемента - целое число |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByName-System-Int32-'></a>
### findNoteByName(quantity) `method`

##### Summary

findNoteByName – выполняет команду SQL, которая осуществляет поиск элемента по полю количества.

##### Returns

возвращает список List элементов типа Item

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quantity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | искомое количество |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-findNoteByName-System-String-'></a>
### findNoteByName(name_) `method`

##### Summary

findNoteByName – выполняет команду SQL, которая осуществляет поиск элемента по полю наименования.

##### Returns

возвращает список List элементов типа Item

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name_ | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | наименование товара |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-openDB-System-String-'></a>
### openDB(existing_db) `method`

##### Summary

openDB – выполняет команду SQL, которая осуществляет открытие существующей базы данных и создание в ней нужной таблицы, если та не существует.

##### Returns

возвращает true в случае успеха, false в случае неудачи

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| existing_db | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-readQuery-MySql-Data-MySqlClient-MySqlCommand-'></a>
### readQuery(myCommand) `method`

##### Summary

readQuery – возвращает результат выполнения sql-запроса в виде списка элементов типа Item.

##### Returns

возвращает список объектов типа Item

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| myCommand | [MySql.Data.MySqlClient.MySqlCommand](#T-MySql-Data-MySqlClient-MySqlCommand 'MySql.Data.MySqlClient.MySqlCommand') | объект команды MySql |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-removeNote-System-Int32-'></a>
### removeNote(id) `method`

##### Summary

removeNote – выполняет команду SQL, которая осуществляет поиск элемента по ID.

##### Returns

возвращает true в случае успеха, false в случае неудачи

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID элемента - целое число |

<a name='M-Сourse_project_Isaeva_21VP1-DBClass-sort-System-String,System-String-'></a>
### sort(field,direction) `method`

##### Summary

sort – выполняет команду SQL, которая осуществляет сортировку записей в таблице по определенному полю в заданном направлении.

##### Returns

возвращает список List объектов типа Item

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | поле, по которому осуществляется поиск элементов |
| direction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | направление поиска |

<a name='T-Сourse_project_Isaeva_21VP1-EditingForm'></a>
## EditingForm `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Форма изменения элемента

<a name='M-Сourse_project_Isaeva_21VP1-EditingForm-#ctor-Сourse_project_Isaeva_21VP1-TheMainForm,Сourse_project_Isaeva_21VP1-Item-'></a>
### #ctor(form2,item) `constructor`

##### Summary

Конструктор формы

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form2 | [Сourse_project_Isaeva_21VP1.TheMainForm](#T-Сourse_project_Isaeva_21VP1-TheMainForm 'Сourse_project_Isaeva_21VP1.TheMainForm') | объект класса TheMainForm - главной формы |
| item | [Сourse_project_Isaeva_21VP1.Item](#T-Сourse_project_Isaeva_21VP1-Item 'Сourse_project_Isaeva_21VP1.Item') | объект класса Item - изменяемый элемент |

<a name='F-Сourse_project_Isaeva_21VP1-EditingForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-Сourse_project_Isaeva_21VP1-EditingForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-Сourse_project_Isaeva_21VP1-EditingForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-Сourse_project_Isaeva_21VP1-Item'></a>
## Item `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Класс Item - хранит записи о товаре.

<a name='M-Сourse_project_Isaeva_21VP1-Item-#ctor'></a>
### #ctor() `constructor`

##### Summary

конструктор объекта класса Item. Заполняет поля значениями по умолчанию

##### Parameters

This constructor has no parameters.

<a name='M-Сourse_project_Isaeva_21VP1-Item-#ctor-System-Int32,System-String,System-DateTime,System-DateTime,System-Int32-'></a>
### #ctor(id,name,productionDate,expirationDate,quantity) `constructor`

##### Summary

конструктор объекта класса Item. Заполняет поля указанными значениями

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | id элемнта, целое число |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | наименование, строка |
| productionDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | дата производства, тип DateTime |
| expirationDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | дата истечения срока годности, тип DateTime |
| quantity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | количество товара, целое число |

<a name='F-Сourse_project_Isaeva_21VP1-Item-count'></a>
### count `constants`

##### Summary

количество созданных объектов

<a name='F-Сourse_project_Isaeva_21VP1-Item-expirationDate'></a>
### expirationDate `constants`

##### Summary

поле дата истечения срока хранения товара

<a name='F-Сourse_project_Isaeva_21VP1-Item-id'></a>
### id `constants`

##### Summary

поле id товара

<a name='F-Сourse_project_Isaeva_21VP1-Item-name'></a>
### name `constants`

##### Summary

поле наименование товара

<a name='F-Сourse_project_Isaeva_21VP1-Item-productionDate'></a>
### productionDate `constants`

##### Summary

поле дата производства товара

<a name='F-Сourse_project_Isaeva_21VP1-Item-quantity'></a>
### quantity `constants`

##### Summary

поле количество товара на складе

<a name='M-Сourse_project_Isaeva_21VP1-Item-ToString'></a>
### ToString() `method`

##### Summary

перегружает метод toString для объекта класса Item

##### Returns

возвращает строку

##### Parameters

This method has no parameters.

<a name='T-Сourse_project_Isaeva_21VP1-Program'></a>
## Program `type`

##### Namespace

Сourse_project_Isaeva_21VP1

<a name='M-Сourse_project_Isaeva_21VP1-Program-Main'></a>
### Main() `method`

##### Summary

Главная точка входа для приложения.

##### Parameters

This method has no parameters.

<a name='T-Сourse_project_Isaeva_21VP1-Properties-Resources'></a>
## Resources `type`

##### Namespace

Сourse_project_Isaeva_21VP1.Properties

##### Summary

Класс ресурсов со строгим типом для поиска локализованных строк и пр.

<a name='P-Сourse_project_Isaeva_21VP1-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Переопределяет свойство CurrentUICulture текущего потока для всех
  подстановки ресурсов с помощью этого класса ресурсов со строгим типом.

<a name='P-Сourse_project_Isaeva_21VP1-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Возврат кэшированного экземпляра ResourceManager, используемого этим классом.

<a name='T-Сourse_project_Isaeva_21VP1-StartingForm'></a>
## StartingForm `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Открывающая форма

<a name='M-Сourse_project_Isaeva_21VP1-StartingForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

Конструктор формы

##### Parameters

This constructor has no parameters.

<a name='F-Сourse_project_Isaeva_21VP1-StartingForm-components'></a>
### components `constants`

##### Summary

Обязательная переменная конструктора.

<a name='M-Сourse_project_Isaeva_21VP1-StartingForm-BlockCreating-System-Boolean-'></a>
### BlockCreating(value) `method`

##### Summary

Метод блокирует кнопку создания базы данных, если открыта основная форма

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Сourse_project_Isaeva_21VP1-StartingForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Освободить все используемые ресурсы.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | истинно, если управляемый ресурс должен быть удален; иначе ложно. |

<a name='M-Сourse_project_Isaeva_21VP1-StartingForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Требуемый метод для поддержки конструктора — не изменяйте 
содержимое этого метода с помощью редактора кода.

##### Parameters

This method has no parameters.

<a name='T-Сourse_project_Isaeva_21VP1-TheMainForm'></a>
## TheMainForm `type`

##### Namespace

Сourse_project_Isaeva_21VP1

##### Summary

Класс основной формы

<a name='M-Сourse_project_Isaeva_21VP1-TheMainForm-#ctor-Сourse_project_Isaeva_21VP1-StartingForm,Сourse_project_Isaeva_21VP1-DBClass-'></a>
### #ctor(form1,db) `constructor`

##### Summary

Конструктор формы

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form1 | [Сourse_project_Isaeva_21VP1.StartingForm](#T-Сourse_project_Isaeva_21VP1-StartingForm 'Сourse_project_Isaeva_21VP1.StartingForm') | объект класса StartingForm - открывающей формы |
| db | [Сourse_project_Isaeva_21VP1.DBClass](#T-Сourse_project_Isaeva_21VP1-DBClass 'Сourse_project_Isaeva_21VP1.DBClass') | объект класса DBClass - текущая база данных |

<a name='F-Сourse_project_Isaeva_21VP1-TheMainForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='F-Сourse_project_Isaeva_21VP1-TheMainForm-db'></a>
### db `constants`

##### Summary

текущая база данных

<a name='M-Сourse_project_Isaeva_21VP1-TheMainForm-AddToDB-Сourse_project_Isaeva_21VP1-Item-'></a>
### AddToDB(item) `method`

##### Summary

Метод добавляет элемент в базу данных, если объект с таким названием не существует.
Иначе предлагает редактировать существующий элемент.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [Сourse_project_Isaeva_21VP1.Item](#T-Сourse_project_Isaeva_21VP1-Item 'Сourse_project_Isaeva_21VP1.Item') | объект класса Item |

<a name='M-Сourse_project_Isaeva_21VP1-TheMainForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-Сourse_project_Isaeva_21VP1-TheMainForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-Сourse_project_Isaeva_21VP1-TheMainForm-updateTable-System-Collections-Generic-List{Сourse_project_Isaeva_21VP1-Item}-'></a>
### updateTable(list) `method`

##### Summary

Метод обновляет таблицу

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.List{Сourse_project_Isaeva_21VP1.Item}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Сourse_project_Isaeva_21VP1.Item}') | текущий список List товаров в базе данных - объектов класса Item |
