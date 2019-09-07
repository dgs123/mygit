using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Properties
{
    /// <summary>
    /// Public class for event data
    /// </summary>
    public class  DivideByZeroArgs
    {
        
    }
    public delegate void DivideByZeroHandler(object sender, DivideByZeroArgs e);
    class Fraction
    {
        // Declare the DivideByZero event for this class
        public event DivideByZeroHandler DivideByZero;

        private long _den;

        // Declare a method to invoke the event
        public virtual void OnDivideByZero(DivideByZeroArgs e)
        {
            if (DivideByZero == null)
            {
                // No handlers,so raise exception
                throw new DivideByZeroException("Divide by zero");
            }
            else
            {
                DivideByZero(this, e);
            }
        }
        //Declare property that can invoke event
        public long Denominator
        {
            get { return this._den; }
            set
            {
                if (value == 0)
                {
                    DivideByZeroArgs args = new DivideByZeroArgs();
                    //OnDivideByZero(this, args);
                    //Do something based on event handler

                }
                else
                {
                    this._den = value;
                }
            }
        }
    }
}
