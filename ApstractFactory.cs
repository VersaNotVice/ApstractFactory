public abstract class Wizard {
    public abstract void DoMagic();
}
public abstract class Goblin
{
    public abstract void DoDamage();
}
public class FireWizard : Wizard
{
    public override void DoMagic()
    {
        Console.WriteLine("Do Fire Magic");
    }
}

public class WaterWizard : Wizard
{
    public override void DoMagic()
    {
        Console.WriteLine("Do Water Magic");
    }
}

public class FireGoblin :Goblin
{
    public override void DoDamage()
    {
        Console.WriteLine("Do Fire Damage");
    }
}

public class WaterGoblin : Goblin
{
    public override void DoDamage()
    {
        Console.WriteLine("Do Water Damage");
    }
}
public abstract class CharacterFactory
{
    public abstract Wizard CreateWizard();
    public abstract Goblin CreateGoblin();
}
public class FireCharacterFactory : CharacterFactory
{
    public override Wizard CreateWizard()
    {
        return new FireWizard();
    }

    public override Goblin CreateGoblin()
    {
        return new FireGoblin();
    }
}
public class WaterCharacterFactory : CharacterFactory
{
    public override Wizard CreateWizard()
    {
        return new WaterWizard();
    }
    public override Goblin CreateGoblin()
    {
        return new WaterGoblin();
    }
    public class GameManager
    {
        public void Play(CharacterFactory factory)
        {
            factory.CreateGoblin();
            factory.CreateWizard();
        }
    }
    public class ClientCode
    {
        public static void Run()
        {
            CharacterFactory FireFactory = new FireCharacterFactory();
            CharacterFactory WaterFactory = new WaterCharacterFactory();

            GameManager gameManager = new GameManager();
            gameManager.Play(FireFactory);
            gameManager.Play(WaterFactory);
        }
    }
}
