using NUnit.Framework;
using UnityEngine;

class CharacterTests
{
    [Test]
    public void Character_Attack_AllTriggeredEnemies()
    {
        // arange
        var character = new GameObject().AddComponent<Character>();
        character.SetAtk(atkVale : 10);
        var enemyGo1       = new GameObject();
        var enemy1Collider = enemyGo1.AddComponent<BoxCollider>();
        var enemy1         = enemyGo1.AddComponent<Enemy>();
    }
}