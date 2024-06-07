# WAD_1
laboratory work on Windows Application Development
Скопировать интерфейс

public interface IPerson

{
int CardNumber { get; }
string Name { get; }
DateTime Bithday { get; }
int calcAge(DateTime date);
}

Создать класс Person реализующий интерфейс IPerson.
Создать форму содержащую список (listBox) [IPerson.Name] - [IPerson.calcAge] и три
кнопки "Создать новую запись", "Изменить выбранную", "Удалить выбранную".
При нажатии "Удалить выбранную" открывается стандартное диалоговое окно с запросом
подтверждения через MessageBox.Show. В случае подтверждения запись удаляется, в
случае отмены остается.
При нажатии кнопок Создать и Изменить открывается "модальное" диалоговое окно
позволяющая ввести/изменить данные.
Имя - TextBox. Дата рождения - DateTimePicker. CardNumber должно сотоять ровно из 5
цифр. Две кнопки "Принять", "Отменить".
Сам класс формы ввода/изменения должен быть один.
При "Изменить выбранную" по умолчанию недоступно изменение CardNumber и Bithday
(поля ввода Enabled = false).
При "Изменить выбранную" можно нажать ctrl+shift+L чтоб открыть немодальное окно
"Выбора логина, ввода пароля".
Создать окно "Выбора логина, ввода пароля" - состоит из выбора логина ComboBox
(значения = user, admin), ввода пароля текстовое поле с *, кнопок "Ok" "Cancel". По
умолчанию выбран user и поле ввода пароля недоступно. При выборе admin становится
доступно окно ввода пароля. При нажатии на Ок сравнивается MD5 от конкатенации строк
логин+пароль с предвычесленным и сохраненным в ПО значением
(System.Security.Cryptography.MD5).
Если при помощи окна "Выбора логина, ввода пароля" удалось перейти в режим
администратора то цвет формы и всех элементов изменяется на другой и становится
доступным ввод "даты рождения" и "номера карты" в режиме Изменить.
В случае изменения номера карты кнопка Принять начинает убегать (плавно изменять
свое местоположение) от мышки не давая себя нажать. Алгоритм может быть любой
главное чтоб кнопка не выходила за границы формы. 
