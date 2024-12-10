namespace StrategyPattern
{
    // ICombatStrategy arayüzü
    public interface ICombatStrategy
    {
        void Attack();
    }

    // AgressiveCombatStrategy sınıfı
    public class AgressiveCombatStrategy : ICombatStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Agressive Attack");
        }
    }

    // DefensiveCombatStrategy sınıfı
    public class DefensiveCombatStrategy : ICombatStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Defensive Attack");
        }
    }

    // Character sınıfı
    public class Character
    {
        private ICombatStrategy _combatStrategy;

        // Yapıcı metot
        public Character(ICombatStrategy combatStrategy)
        {
            _combatStrategy = combatStrategy;
        }

        // Savaş stratejisini değiştirme
        public void SetCombatStrategy(ICombatStrategy combatStrategy)
        {
            _combatStrategy = combatStrategy;
        }

        // Mevcut savaş stratejisini uygula
        public void ApplyAttackStrategy()
        {
            _combatStrategy.Attack();
        }
    }

    // Program sınıfı
    class Combat
    {
        static void Main(string[] args)
        {
            // İlk strateji olarak agresif strateji ile karakter oluşturma
            var character = new Character(new AgressiveCombatStrategy());
            character.ApplyAttackStrategy();

            // Stratejiyi savunma stratejisiyle değiştirme
            character.SetCombatStrategy(new DefensiveCombatStrategy());
            character.ApplyAttackStrategy();

            // Kullanıcının ekranı görmesi için bekletme
            Console.ReadLine();
        }
    }
}