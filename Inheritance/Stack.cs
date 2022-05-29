
namespace Inheritance
{
    public class Stack
    {
        private List<object> arrayListObj;

        public Stack()
        {
            arrayListObj = new List<object>();
        }

        public void Push(object obj)
        {
            try
            {
                if (obj != null)
                {
                        arrayListObj.Add(obj);
                }
                else { throw new InvalidProgramException("Can not pass a null object."); }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public object Pop()
        {
            try
            {
                if (arrayListObj != null && arrayListObj.Count > 0)
                {
                    var obj = arrayListObj[arrayListObj.Count - 1];
                    arrayListObj.RemoveAt(arrayListObj.Count - 1);
                    return obj;
                }
                else { throw new InvalidProgramException("Stack is emplty"); }

            }
            catch (Exception)
            {
                throw new InvalidProgramException("Stackk is emplty");
            }
        }

        public void Clear()
        {
            arrayListObj.Clear();   
        }

    }
}
