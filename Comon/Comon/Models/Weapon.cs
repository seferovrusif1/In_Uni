using System;

namespace Comon.Models;
internal class Weapon
{
    private int _bulletCapacity;
    private int _bulletCount;
    private int _endingTime;

    public int BulletCapacity
    {
        get =>_bulletCapacity;
        set
        {
            if (value>0)
            {
                _bulletCapacity = value;
            }
            else
            {
                Console.WriteLine("\nCapacity 0 dan boyuk olmalidir!!\n");
            }
        } 
    }
    public int BulletCount
    {
        get => _bulletCount;
        set
        {
            if(value>_bulletCapacity)
            {
                Console.WriteLine("\nCount Capacitiyden kicik eraber olmalidir!!\n");

            }
            else if (value < 0 )
            {
                Console.WriteLine("\nCount 0 dan boyuk beraber olmalidir!!\n");
            }
            else
            {
                _bulletCount = value;
            }
        }
    }
    public int EndingTime
    {
        get => _endingTime;
        set
        {
            if (value > 0)
            {
                _endingTime = value;
            }
            else
            {
                Console.WriteLine("\nTime 0 dan boyuk olmalidir!!\n");
            }
        }
    }
    public bool FireMod { get; set; }
    public Weapon(int BulletCapacity,int BulletCount, int EndingTime)
    {
        this.BulletCapacity = BulletCapacity;
        this.BulletCount = BulletCount;
        this.EndingTime = EndingTime;
    }
    public void Shoot()
    {
        if (BulletCount > 0)
        {
            BulletCount -= 1;
            Console.WriteLine("\n1 gulle atdi\n");
        }
        else
        {
            Console.WriteLine("\nDaraq bosdur!!!\n");
        }
    }
    public void Fire()
    {
        if (BulletCount > 0)
        {
            if (FireMod)
            {
                Console.WriteLine((EndingTime / BulletCapacity) * BulletCount + ".. Saniyede bitdi");
                BulletCount = 0;
            }
            else
            {
                BulletCount -= 1;
                Console.WriteLine("\n1 gulle atdi\n");

            }
        }
        else
        {
            Console.WriteLine("Daraq bosdur!!!");
        }
    }
    public int GetNeededBulletCount()
    {
        return BulletCapacity-BulletCount;
    }
    public void Reload()
    {
        if (BulletCount < BulletCapacity)
        {
            BulletCount = BulletCapacity;
            Console.WriteLine("Daraq doldu");
        }
        else if (BulletCount == BulletCapacity)
        {
            if (BulletCount==0)
            {
                Console.WriteLine("CApacity ve count 0 dir");
            }
            else
            {
            Console.WriteLine("\nDaraq doludur!\n");
               
            }

        }
        else
        {
            Console.WriteLine("Yanlis deyer!!");
        }
    }
    public void ChangeFireMode()
    {
        FireMod = !FireMod;
    }
    public void GetFullInfo()
    {
        string p;
        if (FireMod)
        {
            p= "Auto";
        }
        else
        {
            p = "Single";
        }
        Console.WriteLine($"\nBullet capacity: {BulletCapacity}\nBullet Count: {BulletCount}\nEnding Time: {EndingTime}\nShot mod: {p}\n");
    }
    public void Edit()
    {
        Console.WriteLine("\n1.Update BulletCapacity 2.Update BulletCount 3.Update EndingTime\n");
        string d = Console.ReadLine();
        switch (d)
        {
            case "1":
                Console.WriteLine("\nYeni capacity daxil edin: ");
                EditCapacity(Convert.ToInt32(Console.ReadLine()));
                break;
            case "2":
                Console.WriteLine("\nYeni Count daxil edin: ");
                EditCount(Convert.ToInt32(Console.ReadLine()));
                break;
            case "3":
                Console.WriteLine("\nYeni Ending Time daxil edin: ");
                EditTime(Convert.ToInt32(Console.ReadLine()));
                break;
        }
    }
        


    public void EditCapacity(int BulletCapacity)
    {
        this.BulletCapacity = BulletCapacity;
    }
    public void EditCount(int BulletCount)
    {
        this.BulletCount = BulletCount;
    }
    public void EditTime(int EndingTime)
    {
        this.EndingTime = EndingTime;
    }



}
