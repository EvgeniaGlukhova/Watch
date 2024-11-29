using Microsoft.Maui.Controls.Shapes;

namespace Watch 
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // связь визуальных элементов 
            Device.StartTimer(TimeSpan.FromSeconds(1), UpdateTime); //  запускает таймер и обновляет каждую секунду
        }

        

        // Функция для обновления времени
        private bool UpdateTime()
        {
            // Получаем текущее время в часовом поясе Екатеринбург +2
            TimeZoneInfo ekbPlus2TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time"); // Екатеринбург
            DateTime ekbPlus2Time = TimeZoneInfo.ConvertTime(DateTime.Now, ekbPlus2TimeZone).AddHours(2);

            // Извекаем из  полученного времени часы и минуты
            int hours = ekbPlus2Time.Hour;
            int minutes = ekbPlus2Time.Minute;
            int second = ekbPlus2Time.Second;

            // Разделение по цифрам
            int firstHourDigit = hours / 10;    // первая  часы 
            int secondHourDigit = hours % 10;   // вторая часы
            int firstMinuteDigit = minutes / 10; // первая минута
            int secondMinuteDigit = minutes % 10; // вторая цифр минут
            int thirdSecondDigit = second / 10; // первая секунда 
            int secondSecondDigit = second % 10; // вторая секунда 

            // Отображаем цифры на экране
            UpdateDigitSegments(firstHourDigit, TopSegment1, TopLeftSegment1, TopRightSegment1, MiddleSegment1, BottomLeftSegment1, BottomRightSegment1, BottomSegment1); 
            UpdateDigitSegments(secondHourDigit, TopSegment2, TopLeftSegment2, TopRightSegment2, MiddleSegment2, BottomLeftSegment2, BottomRightSegment2, BottomSegment2);
            
            UpdateDigitSegments(firstMinuteDigit, TopSegment3, TopLeftSegment3, TopRightSegment3, MiddleSegment3, BottomLeftSegment3, BottomRightSegment3, BottomSegment3);
            UpdateDigitSegments(secondMinuteDigit, TopSegment4, TopLeftSegment4, TopRightSegment4, MiddleSegment4, BottomLeftSegment4, BottomRightSegment4, BottomSegment4);
          
            UpdateDigitSegments(thirdSecondDigit, TopSegment5, TopLeftSegment5, TopRightSegment5, MiddleSegment5, BottomLeftSegment5, BottomRightSegment5, BottomSegment5);
            UpdateDigitSegments(secondSecondDigit, TopSegment6, TopLeftSegment6, TopRightSegment6, MiddleSegment6, BottomLeftSegment6, BottomRightSegment6, BottomSegment6);

            return true; // вызывает функцию каждую секунду 
        } 

        private void UpdateDigitSegments(int digit, Rectangle top, Rectangle topLeft, Rectangle topRight, Rectangle middle, Rectangle bottomLeft, Rectangle bottomRight, Rectangle bottom)
        {
            top.IsVisible = true;
            topLeft.IsVisible = true;
            topRight.IsVisible = true;
            middle.IsVisible = true;
            bottomLeft.IsVisible = true;
            bottomRight.IsVisible = true;
            bottom.IsVisible = true;  // начальное состояние 

            switch (digit)
            {
                case 0:

                    top.IsVisible = true;   //это просто скрывает сегмент, верхний 
                    topLeft.IsVisible = true; //верхний левый 
                    topRight.IsVisible = true; //верхний правый 
                    middle.IsVisible = false;  //средний
                    bottomLeft.IsVisible = true;  //нижний левый
                    bottomRight.IsVisible = true;  //нижний правый
                    bottom.IsVisible = true;  // нижний
                    break;


                case 1:
                    top.IsVisible = false;
                    topLeft.IsVisible = false;
                    topRight.IsVisible = true;
                    middle.IsVisible = false;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = false;
                    break;



                case 2:
                    top.IsVisible = true;
                    topLeft.IsVisible = false;
                    topRight.IsVisible = true;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = true;
                    bottomRight.IsVisible = false;
                    bottom.IsVisible = true;
                    break;



                case 3:
                    top.IsVisible = true;
                    topLeft.IsVisible = false;
                    topRight.IsVisible = true;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = true;
                    break;



                case 4:
                    top.IsVisible = false;
                    topLeft.IsVisible = true;
                    topRight.IsVisible = true;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = false;
                    break;



                case 5:
                    top.IsVisible = true;
                    topLeft.IsVisible = true;
                    topRight.IsVisible = false;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = true;
                    break;


                case 6:
                    top.IsVisible = true;
                    topLeft.IsVisible = true;
                    topRight.IsVisible = false;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = true;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = true;
                    break;



                case 7:
                    top.IsVisible = true;
                    topLeft.IsVisible = false;
                    topRight.IsVisible = true;
                    middle.IsVisible = false;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = false;
                    break;



                case 8:
                    top.IsVisible = true;
                    topLeft.IsVisible = true;
                    topRight.IsVisible = true;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = true;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = true;
                    break;



                case 9:
                    top.IsVisible = true;
                    topLeft.IsVisible = true;
                    topRight.IsVisible = true;
                    middle.IsVisible = true;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = true;
                    bottom.IsVisible = true;
                    break;



                default:
                    // Если цифра не распознана, скрываем все сегменты
                    top.IsVisible = false;
                    topLeft.IsVisible = false;
                    topRight.IsVisible = false;
                    middle.IsVisible = false;
                    bottomLeft.IsVisible = false;
                    bottomRight.IsVisible = false;
                    bottom.IsVisible = false;
                    break;
            }
        }
    }
}
