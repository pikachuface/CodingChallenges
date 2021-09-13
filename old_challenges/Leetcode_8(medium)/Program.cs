namespace Leetcode_8_medium_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

	public class SubrectangleQueries 
	{
		private int[][] rectangle;

    	public SubrectangleQueries(int[][] rectangle) 
		{
        	this.rectangle = rectangle;	
    	}
    
   		public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) 
		{
       		for(int x = row1; x <= row2; x++)
			{
       			for(int y = col1; y <= col2; y++)
				{
					rectangle[x][y] = newValue;
				}	
			}	
    	}
    
    	public int GetValue(int row, int col) 
		{
			return rectangle[row][col];
    	}
	}
}
/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */
