namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            
            return enemy.flying || enemy.incoporial || enemy.subterranian;
        }

        internal bool CanPassWater(Enemy enemy)
        {
           
            return enemy.flying || enemy.incoporial || enemy.subterranian || enemy.swimmer;
        }
    }
}
