using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class Car
	{

		#region Arributes
		private int id;
		private string model;
		private double speed;
		#endregion

		#region properties
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		#endregion

		#region method
		public override string ToString()
		{
			return $" {id}\n Model : {model} \n Speed : {speed}";
		}
        #endregion


        public Car(int _id , string _model  , double _speed)
        {
            int id = _id ;
			model = _model ;
			speed = _speed ;

        }
		public Car(int _id, string _model) : this (_id , _model , 280 )
		{
			//id = _id ;	
			//model = _model ;
			//speed = 280;	
		}

        public Car(int _id) : this(_id , "kai")
        {
        //    id= _id ;
        //    model = "kai";
              speed = 180;

        }
        public Car()
        {
            
        }

    }
}
