PlayerWeapon actualWeapon = new BasicPower();
PlayerWeapon enemyWeapon = new BigEnemy();
int Result = 0;
Console.WriteLine("You are facing this enemy:");
Console.WriteLine(enemyWeapon.NameWeapon());
Console.WriteLine(enemyWeapon.Damage() + "Points");

Console.WriteLine("Your weapon has 10 points damage, to defeat your enemy you need an AddOn");
Console.WriteLine("Please choose an AddOn to continue...");
Console.WriteLine("1. Fire Ball");
Console.WriteLine("2. Random Power");
Console.WriteLine("3. Steal Sword");
Console.WriteLine("4. Laser Rays");
Console.WriteLine("5. Exit");
var input = Console.ReadLine();
Console.WriteLine("You have damaged:");

if (input == "1")
{
    actualWeapon = new AddOnFireBall(actualWeapon);

    Console.WriteLine(actualWeapon.NameWeapon());
    Console.WriteLine(actualWeapon.Damage() + "Points");
    Result = actualWeapon.Damage() - enemyWeapon.Damage();
    Console.WriteLine();

}
else if (input == "2")
{
    actualWeapon = new AddOnRandomPower(actualWeapon);
    Console.WriteLine(actualWeapon.NameWeapon());
    Console.WriteLine(actualWeapon.Damage());
    Result = actualWeapon.Damage() - enemyWeapon.Damage();
}
else if (input == "3")
{
    actualWeapon = new AddOnStealSword(actualWeapon);
    Console.WriteLine(actualWeapon.NameWeapon());
    Console.WriteLine(actualWeapon.Damage());
    Result = actualWeapon.Damage() - enemyWeapon.Damage();
}
else if (input == "4")
{
    actualWeapon = new AddOnLaserRays(actualWeapon);
    Console.WriteLine(actualWeapon.NameWeapon());
    Console.WriteLine(actualWeapon.Damage());
    Result = actualWeapon.Damage() - enemyWeapon.Damage();
}
else
{
    Environment.Exit(-1);
}



if (Result > 0)
{
    Console.WriteLine("You Win");
}
else if (Result == 0)
{
    Console.WriteLine("you are even");
}
else
{
    Console.WriteLine("You Lose!");
}

Console.Read();

public abstract class PlayerWeapon
{
    protected string _nameWeapon { get; set; }
    public virtual string NameWeapon()
    {
        return _nameWeapon;
    }

    protected int _damage { get; set; }
    public virtual int Damage()
    {
        return _damage;
    }

}

public class BasicPower : PlayerWeapon
{

    public BasicPower()
    {
        _nameWeapon = "Basic Power";
        _damage = 10;
    }

}

public abstract class AddOnDecorator : PlayerWeapon
{
    public PlayerWeapon PlayerWeapon { get; set; }
    public abstract override string NameWeapon();
    public abstract override int Damage();
}

public class AddOnFireBall : AddOnDecorator
{
    public AddOnFireBall(PlayerWeapon playerWeapon)
    {
        PlayerWeapon = playerWeapon;

    }
    public override string NameWeapon()
    {
        return PlayerWeapon.NameWeapon() + " + Fire Ball";
    }

    public override int Damage()
    {
        return PlayerWeapon.Damage() + 8;
    }

}


public class AddOnRandomPower : AddOnDecorator
{
    public AddOnRandomPower(PlayerWeapon playerWeapon)
    {
        PlayerWeapon = playerWeapon;

    }
    public override string NameWeapon()
    {
        return PlayerWeapon.NameWeapon() + "+ Random Power";
    }

    public override int Damage()
    {
        return PlayerWeapon.Damage() + 6;
    }

}

public class AddOnStealSword : AddOnDecorator
{
    public AddOnStealSword(PlayerWeapon playerWeapon)
    {
        PlayerWeapon = playerWeapon;

    }
    public override string NameWeapon()
    {
        return PlayerWeapon.NameWeapon() + ", Steal Sword";
    }

    public override int Damage()
    {
        return PlayerWeapon.Damage() + 11;
    }

}

public class AddOnLaserRays : AddOnDecorator
{
    public AddOnLaserRays(PlayerWeapon playerWeapon)
    {
        PlayerWeapon = playerWeapon;

    }
    public override string NameWeapon()
    {
        return PlayerWeapon.NameWeapon() + ", Laser Rays";
    }

    public override int Damage()
    {
        return PlayerWeapon.Damage() + 3;
    }

}


public class BigEnemy : PlayerWeapon
{
    public BigEnemy()
    {
        _nameWeapon = " EnemyGun";
        _damage = 17;
    }
}


