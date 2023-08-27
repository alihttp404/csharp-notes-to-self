using Struct__Class;

// Struct
PointStruct point; // Stack
PointStruct point2 = new PointStruct(); // Also stack

point.x = 10;
point.y = 20;

point2.x = 21;
point2.y = 123;

point2 = point;
Console.Write(point2.x); // still 21, because it works with copy of data