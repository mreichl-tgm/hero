namespace Effects.ActivatableEffects
{
    public abstract class ActivatableEffect : Effect, IActivatable
    {
        public abstract void Activate();
    }
}