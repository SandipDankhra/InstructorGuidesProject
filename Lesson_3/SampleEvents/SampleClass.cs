using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEvents
{
  
    public class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent;
        public void Invoke()
        {
            if (SampleEvent != null)
                SampleEvent();
        }
    }
    public delegate void SampleDelegate();
    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }
}
