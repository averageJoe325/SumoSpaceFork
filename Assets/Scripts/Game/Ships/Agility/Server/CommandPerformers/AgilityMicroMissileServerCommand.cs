using Game.Common.Gameplay.Commands;
using Game.Common.Gameplay.Ship;

namespace Game.Ships.Agility.Server.CommandPerformers
{
    public class AgilityMicroMissileServerCommand: ICommand {
        public bool Receive(ShipManager shipManager, CommandNetworkerData networker, CommandPacketData packetData) {
            shipManager.shipLoadout.SecondaryAbility.Execute(shipManager, true);
            networker.Send(packetData);
            return true;
        }
    }
}
