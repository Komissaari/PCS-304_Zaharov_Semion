
namespace _Motor_
{
    public delegate void MyEvent();
    public class Motor
    {
        public Motor() { }
        public MyEvent _Event; 

        public void Event() 
        {
            _Event?.Invoke();
        }
    }
}
