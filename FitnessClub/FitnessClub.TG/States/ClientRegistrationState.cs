using FitnessClub.BLL;
using FitnessClub.BLL.Models.PersonModels.InputModels;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace FitnessClub.TG.States
{
    public class ClientRegistrationState : AbstractState
    {
        public override AbstractState ReceiveMessage(Update update)
        {
            var Name = update.Message.Text;

            SingletoneStorage.GetStorage().Client.SendTextMessageAsync(update.Message.Chat.Id, $"Рады знакомству, {Name}!");

            long id = update.Message.Chat.Id;
            PersonClient personClient = new PersonClient();
            RegistrationPersonInputModel model = new RegistrationPersonInputModel();
            personClient.AddPerson(model);
            return new StartState(Name);
        }

        public override async void SendMessage(long chatId)
        {
            await SingletoneStorage.GetStorage().Client.SendTextMessageAsync(chatId, $"Как Вас зовут?");
        }
    }
}
