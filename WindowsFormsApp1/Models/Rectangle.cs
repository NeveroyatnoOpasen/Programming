using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{ 
public class Rectangle //конструктор класса прямоугольник
{
    // Поля (данные класса)
    private int width;
    private int height;
    private string _name;
    private string color;
    private static int _allRectanglesCount; //Статичесское поле будет считать все созданные треугольники когда либо создданные
                                            // так как статическое поле относится ко всему классу
    private int _id;
    public Point2D Center { get; private set; }
    // Конструктор (инициализация объекта)
    public Rectangle(int width, int height, Point2D Center)
    {
        Validator.AssertOnPositiveValue(width, nameof(Width));
        Validator.AssertOnPositiveValue(height, nameof(Height));

        this.width = width;
        this.height = height;
        this.Center = Center; // Без валидации
        _allRectanglesCount++;
        this._id = _allRectanglesCount;

    }
    public int Id => _id;
    // Свойства (доступ к полям)
    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; } //Что за value?
    }
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public static int AllRectanglesCount()
    {
        return _allRectanglesCount;
    }
}

}
