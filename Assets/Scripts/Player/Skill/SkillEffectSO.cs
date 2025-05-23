using UnityEngine;

public abstract class SkillEffectSO : ScriptableObject, ISkillEffect
{
    protected static readonly string damageableString = "Damageable";
    public abstract void Activate(StatusContext context);
    [SerializeField] protected GameObject attackParticle;
}
