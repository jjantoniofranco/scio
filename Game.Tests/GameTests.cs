using GameEngine.Abstractions;
using GameEngine.Characters;
using GameEngine.Items;

namespace Game.Tests
{
    public class GameTests
    {
        [Theory]
        [InlineData(typeof(Paladin), typeof(Espada), "Conan ha partido en dos al enemigo")]
        [InlineData(typeof(Elfo), typeof(Arco), "Legolas ha acertado en el corazón del enemigo")]
        [InlineData(typeof(Mago), typeof(Hechizo), "Merlin ha convertido en mono al enemigo")]
        [InlineData(typeof(Paladin), typeof(Arco), "Conan ha acertado en el corazón del enemigo")]
        [InlineData(typeof(Elfo), typeof(Hechizo), "Legolas ha convertido en mono al enemigo")]
        [InlineData(typeof(Mago), typeof(Espada), "Merlin ha partido en dos al enemigo")]
        public void AvatarAndWeapon_ReturnsRightAttack(Type tipoPersonaje, Type tipoArma, string mensajeEsperado)
        {
            // Arrange
            var arma = (IWeapon)Activator.CreateInstance(tipoArma)!;
            var personaje = (IGameAvatar)Activator.CreateInstance(tipoPersonaje, arma)!;

            // Act
            var resultado = personaje.Attack();

            // Assert
            Assert.Equal(mensajeEsperado, resultado);
        }
    }
}
