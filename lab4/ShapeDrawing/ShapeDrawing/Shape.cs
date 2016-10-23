using System;
using System.Drawing;

public abstract class Shape
{
    public int x;
    public int y;
    public int size;
    public int width;
    public int height;

	public Shape()
	{
	}

    public abstract void Draw(Graphics Canvas);
	
}