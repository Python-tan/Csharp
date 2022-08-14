using System;

namespace C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Class cla = new Class ();
			cla.a = 1;
			cla.d = 2;
			const double de = 3.141;
			bool a = false;
			int i = Convert.ToInt32(Console.ReadLine());
			float f = 53.005f;
			int Bi = (int)f;
			if (a) {
				Console.WriteLine ("a is true");
			
			} else {
				for(int whi=0;whi<=9;whi++){
					Console.WriteLine (i+"fuck");
				}
			}
			Console.WriteLine (Bi);
			string str =i.ToString ();
			int BBi = Convert.ToInt32 (str);//或者int bbi = int.parse(str);
			Console.WriteLine(str+"\n"+BBi+"\n"+de);

			ArrayClass array = new ArrayClass ();
			array.FuncArray ();

			Console.WriteLine ("\n");
			Console.WriteLine ("总和:"+cla.Int(1,2,3,4,5));

		}
	}
	class Class
	{
		public int a;
		private int b;
		protected int c;
		internal int d;
		public int Int(params int[]arr)
		{
			int sum = 0;
			foreach (int i in arr) 
			{
				sum += i;
			}
			return sum;
		}
	}
	class ArrayClass
	{
		public void FuncArray()
		{
			Console.WriteLine ("\n");
			int[][] CrossArr = new int[][] { new int[]{ 1, 2, 3 }, new int[]{ 4, 5, 6 } ,new int[]{7,8,9}};//交错数组，数组的数组
			int[,] DoubleArr=
			{
				{1,2,3},
				{4,5,6},
				{7,8,9}
			};//多维数组，三维数组:int[,,]
			int[] arr = new int[3];
			for(int i=0;i<=2;i++)
			{
				arr [i] = i * 100+100;
				Console.WriteLine(DoubleArr[1,i]);
				Console.WriteLine(DoubleArr.Rank);
				Console.WriteLine(CrossArr[i][i]);
			}
			foreach (int j in arr)
			{
				Console.WriteLine (j);
			}

		}
	}
}
