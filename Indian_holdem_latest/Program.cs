namespace Indian_holdem_latest
{
    internal class Program
    { 

        public static void Main(string[] args)
        {
            //1~10까지 20장의 숫자카드를 생성한다.
            //List<Card> cards = new List<Card>();
            
            //유저와 컴퓨터는 각각 20개의 칩을 가지고 시작한다.
            User user = new User(20);
            OneSideEar oneSideEar = new OneSideEar(20);

            List<Player> players = new List<Player>();
            players.Add(user);
            players.Add(oneSideEar);

            while (true)
            {
                if (user.Chip == 0 || oneSideEar.Chip == 0)
                    break;


                //딜러가 카드를 섞는다.
                Dealer dealer = new Dealer();
                dealer.Prepare();



                //등교한다.
                //딜러가 카드 한장은 중앙에, 한장은 유저 그리고 한장은 컴퓨터에게 나눠준다.
                //유저는 중앙에 있는 카드와 컴퓨터의 카드만 보인다.
                //베팅한다.
                //유저의 카드를 확인하여 높은 숫자의 승자를 결정한다.
                //사용된 카드는 버린다.
                //카드가 3장 이하면 다시 20개 카드가 생성된다.
                //판돈이 오링나면 게임은 끝난다.
            }
        }
    }
}