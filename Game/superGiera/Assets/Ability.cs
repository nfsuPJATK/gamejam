using System.Collections.Generic;

public enum AbilityType { AREA_OF_EFFECT, BUFF, HEAL, OFFENSIVE }
public enum TargetType { SELF, ENEMY }
public class Ability
{
    public List<AbilityType> abilityTypes;
    public string name;
    public int numberOfTargets;
    public TargetType targetType;

}