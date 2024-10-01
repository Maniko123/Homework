using UnityEngine;

[RequireComponent (typeof(Renderer))]

public class CubeStats : MonoBehaviour
{
    [SerializeField] private float _successChanceValue = 100;
    [SerializeField] private float _minPercent = 0;
    [SerializeField] private float _maxPersent = 100;
    [SerializeField] private float _multiplyChanceDenominator = 2;
    [SerializeField] private float _explosionPotential = 1;
    [SerializeField] private float _explosionPotentialMultiplier = 2;

    public float ExplosionPotential { get; private set; }

    private void Awake()
    {
        ExplosionPotential = _explosionPotential;
    }

    public bool IsAbleToMultiply()
    {
        return Random.Range(_minPercent, _maxPersent) <= _successChanceValue;
    }

    public void DecreaseMultiplyChance()
    {
        _successChanceValue /= _multiplyChanceDenominator;
    }

    public void IncreaseExplosionPotential()
    {
        _explosionPotential *= _explosionPotentialMultiplier;
        ExplosionPotential = _explosionPotential;
    }
}
