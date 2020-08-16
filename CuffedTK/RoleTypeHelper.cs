using Synapse;
using Synapse.Api;

namespace CuffedTK
{
    public static class RoleTypeHelper
    {
        public static bool IsNtf(this RoleType role) => role.ToString().ToLower().Contains("ntf");
        public static bool IsDClassTeam(this RoleType role) => role == RoleType.ClassD || role == RoleType.ChaosInsurgency;
        public static bool IsScientistTeam(this RoleType role) => IsNtf(role) || role == RoleType.FacilityGuard || role == RoleType.Scientist;
    }
}