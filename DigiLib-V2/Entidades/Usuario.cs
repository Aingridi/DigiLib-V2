using System.Security.Claims;

namespace DigiLibV2.Entidades {
    internal class Usuario {
        public ClaimsIdentity Nome { get; internal set; }
        public object Id { get; internal set; }
    }
}