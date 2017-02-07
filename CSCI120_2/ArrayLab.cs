using System;
namespace CSCI120_2
{
	public class ArrayLab :IArrayLab
	{
		public ArrayLab()
		{
		}

		private string tempString;

		public object[] myArray;

		public object[] MakeArray (int length)
		{ 
			return new object[length];
		}

		public void Add(object value, object[] data)
		{
			data[Count(data)] = value;
		}

		public void Clear(object[] data)
		{
			throw new NotImplementedException();
		}

		public int Count(object[] data)
		{
			int nonNull=0;
			foreach (object i in data)
			{
				if (i != null) { nonNull += 1; }
			}
			return nonNull;
		}

		public int IndexOf(object value, object[] data)
		{
			int slot;
			slot = 0;
			bool yeboi;
			yeboi = false;
			foreach (object i in data) 
			{
				if (float.Equals(i, value)) { yeboi = true; break;}
				if (i == value) { yeboi = true; break; }
				else { slot++; }
			}
			if (yeboi == true) { return slot; }
			else { return -1; }
		}

		public string MakeString(object[] data)
		{
			tempString = "";
			foreach (object i in data) { tempString += i; }
			return tempString;
		}

		public string MakeString(object[] data, string sep)
		{
			throw new NotImplementedException();
		}

		public void Remove(int index, object[] data)
		{
			if (index >= 0 && index < Count(data)) {
				data[index] = data[Count(data)-1];
				data[Count(data) - 1] = null;
			}
		}
	}
}
