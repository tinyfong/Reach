using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Reach.Models;

namespace Reach.DAL
{
    public class ReachInitializer : DropCreateDatabaseIfModelChanges<ReachContext>
    {
        protected override void Seed(ReachContext context)
        {
            #region Add Videos
            var v1 = new Video()
            {

                Name = "吸血鬼日记 第六季",
                Description = "在本季的故事中，埃琳娜采用一种反传统的、可能极其危险的方法来排解失去达蒙的痛苦，随后她返回大学开始二年级的学业。卡罗琳不愿放弃Mystic Falls，相反，她竭尽全力寻找一种能逆转“旅行者”反魔法咒语的方法。她不停给斯特凡打电话，但斯特凡拒绝回应她，这让她越来越感到沮丧。再次成为人类的泰勒在一次停车场聚会中与别人发生矛盾，他控制愤怒的能力面临考验。马特担心杰米正在用一种自毁的方式来排解失去邦妮的痛苦感。Alaric忙于适应作为一个吸血鬼的“新生活”。当他见到学校医院的美貌医生之后，他陷入一种非常尴尬的情形。每个人都相信斯特凡正在寻找营救达蒙和邦妮的方法，但……他到底在忙些什么？",
                YoukuId = "XODg3ODYwODgw",
                Url = "http://player.youku.com/embed/XODg3ODYwODgw",
                Rank = 1,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 1, 1)
            };

            var v2 = new Video
            {

                Name = "【权力的游戏】第五季 全长预告",
                Description = "主演: 麦茜·威廉姆斯 / 艾米莉亚·克拉克 / 伊萨克·亨普斯特德-怀特 / 斯蒂芬·迪兰 / 彼特·丁拉基",
                YoukuId = "XOTEzMDA2NTA4",
                Url = "http://player.youku.com/embed/XOTEzMDA2NTA4",
                Rank = 2,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 1, 2)
            };

            var v3 = new Video
            {

                Name = "马达加斯加3 Madagascar 3 2012(预告片)",
                Description = "在非洲游历了一圈之后，纽约中央公园的四位明星们继续着回到纽约，回到中央公园的旅程。不过，只要旅途中有猩猩和那群企鹅的“帮忙”，旅程就没有想象中的那么顺利。在蒙特卡洛的一家赌场里，由于大家的耍宝，大闹赌场，进而招致了心狠手辣的动物管理局上尉杜波依斯的围追堵截。为了逃过追捕，大家逃进了一个在欧洲进行巡回演出的马戏团。在马戏团里，大家延续着“马达加斯加”式的幽默，笑料百出。虽然，欧洲这一路上的旅行并不顺利，不断受到杜波依斯上尉的追捕威胁，不过大家一直怀揣着回到纽约，回到纽约中央公园的梦想。在马戏团，还帮助了东北虎维塔利、美洲虎吉亚以及海狮斯蒂芬诺重拾对马戏表演的信心。",
                YoukuId = "XMzMwNTkyNDI4",
                Url = "http://player.youku.com/embed/XMzMwNTkyNDI4",
                Rank = 2,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 2, 1)
            };

            var v4 = new Video
            {

                Name = "变形金刚3",
                Description = "距今50多年前，一艘来自赛博坦的飞船坠落月球，由此引发了美苏两国的太空竞赛。人类争相登上月球，只为一探飞船残骸中的秘密。时间回到21世纪初，经过几番征战，汽车人终于挫败霸天虎的入侵，继而与人类合作，共同保卫美丽的地球。然而发生在切尔诺贝利的事件却将尘封已久的月球计划重新摆到桌面。为了防止霸天虎找到能量柱为非作歹，擎天柱与战友飞赴月球，更从当年的飞船中救出了汽车人的先代领导者——御天敌。御天敌是能量柱的发明者，将上百根能量柱集合在一起便可制造太空桥，实现物质的瞬间传送。",
                YoukuId = "XMjcwNjYwNTIw",
                Url = "http://player.youku.com/embed/XMjcwNjYwNTIw",
                Rank = 2,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 3, 1)
            };

            var v5 = new Video
            {

                Name = "速度与激情5",
                Description = "蛰伏2年之后，唐老大（范·迪塞尔 饰）与布莱恩（保罗·沃克 饰）再度联手把火车中的神秘豪车盗走，遭到了警察和黑帮分子的火线追杀。布莱恩和米亚（乔丹娜·布鲁斯特 饰）到里约寻找援兵，并与多米会和。为了寻找多米等人的下落，FBI王牌探员路克·哈柏（道恩·强森 饰）挺身而出，组成精英部队，追查来到里约。他雇佣了丧夫的美丽女警艾莲娜（埃尔莎·帕塔奇 饰），一同寻找多米。与此同时，里约的地头蛇也对这些不速之客开火。三股势力开始相互缠斗。",
                YoukuId = "XMjQyMDM2NzY0",
                Url = "http://player.youku.com/embed/XMjQyMDM2NzY0",
                Rank = 2,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 3, 1)
            };

            var v6 = new Video
            {

                Name = "《超能陆战队》台湾正式版预告片",
                Description = "未来世界的超级都市旧京山，一个热爱发明创造的天才少年小宏（瑞恩·波特 饰），在哥哥泰迪（丹尼尔·海尼 饰）的鼓励下参加了罗伯特·卡拉汉教授（詹姆斯·克伦威尔 饰）主持的理工学院机器人专业的入学大赛。他凭借神奇的微型磁力机器人赢得观众、参赛者以及考官的一致好评，谁知突如其来的灾难却将小宏的梦想和人生毁 于一旦。大火烧毁了展示会场，而哥哥为了救出受困的卡拉汉教授命丧火场。身心饱受创伤的小宏闭门不出，哥哥生前留下的治疗型机器人大白（斯科特·埃德希特 饰）则成为安慰他的唯一伙伴。原以为微型机器人也毁于火灾，谁知小宏和大白竟意外发现有人在某座废弃工厂内大批量地生产他的发明。 　　稍后哥哥的朋友们弗雷德（T·J·米勒 饰）等人也加入进来，他们穿上小宏发明的超级战士战斗装备，和怀有险恶阴谋的神秘对手展开较量。",
                YoukuId = "XODEzODI3NDky",
                Url = "http://player.youku.com/embed/XODEzODI3NDky",
                Rank = 2,
                Customer = "Youku",
                UpdateTime = new DateTime(2015, 4, 1)
            };

            var videos = new List<Video>() {
            v1,v2,v3,v4,v5,v6
            };

            videos.ForEach(x => context.Videos.Add(x));
            #endregion

            //#region Add UserProfiles
            //var u1 = new UserProfile()
            //{
            //    UserName = "admin",
            //    Password = "1"
            //};
            //var userProfiles = new List<UserProfile>() {
            // u1
            //};
            //userProfiles.ForEach(x => context.UserProfiles.Add(x));

            //#endregion

            context.SaveChanges();
        }

    }
}