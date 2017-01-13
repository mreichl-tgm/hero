namespace Assets.Scripts.Effect.ActivatableEffect
{
    public abstract class ActivatableEffect : Effect, IActivatable {
        public abstract void Activate();
    }
}