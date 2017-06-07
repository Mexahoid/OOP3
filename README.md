# OOP3
Векторный графический редактор

Разработать простейший векторный графический редактор с различными фигурами.

Используемые классы (примерный перечень):

•	Интерфейс фигура

•	Конкретные фигуры (Линия, Прямоугольник, Овал)

•	Векторная картинка

•	Подсистема прорисовки

•	Контроллер

Используемые паттерны (примерный перечень):

•	Абстрактная фабрика для порождения фигур. При порождении фигур в них сохраняется ссылка на подсистему прорисовки.

•	Прототип для копирования фигур.

•	Компоновщик для объединения нескольких фигур в один объект.

•	Каждое действие над фигурой сохраняется в виде команды для того, чтобы команды можно было бы потом отменять.

•	Итератор для всех фигур и итератор для фигур в составной фигуре (компоновщике).
