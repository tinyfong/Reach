using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Reach.Models;

namespace Reach.DAL
{
    public class VideoInitializer : DropCreateDatabaseIfModelChanges<VideoContext>
    {
        protected override void Seed(VideoContext context)
        {
            var videos = new List<Video> { 

            new Video
            {Id=1, Name="吸血鬼日记 第六季", Description ="在本季的故事中，埃琳娜采用一种反传统的、可能极其危险的方法来排解失去达蒙的痛苦，随后她返回大学开始二年级的学业。卡罗琳不愿放弃Mystic Falls，相反，她竭尽全力寻找一种能逆转“旅行者”反魔法咒语的方法。她不停给斯特凡打电话，但斯特凡拒绝回应她，这让她越来越感到沮丧。再次成为人类的泰勒在一次停车场聚会中与别人发生矛盾，他控制愤怒的能力面临考验。马特担心杰米正在用一种自毁的方式来排解失去邦妮的痛苦感。Alaric忙于适应作为一个吸血鬼的“新生活”。当他见到学校医院的美貌医生之后，他陷入一种非常尴尬的情形。每个人都相信斯特凡正在寻找营救达蒙和邦妮的方法，但……他到底在忙些什么？", YoukuId="XODg3ODYwODgw",Url="http://player.youku.com/embed/XODg3ODYwODgw", Rank=1, Customer="Youku", UpdateTime=new DateTime(2015,1,1)},
               new Video
            {Id=1, Name="【权力的游戏】第五季 全长预告", Description ="主演: 麦茜·威廉姆斯 / 艾米莉亚·克拉克 / 伊萨克·亨普斯特德-怀特 / 斯蒂芬·迪兰 / 彼特·丁拉基", YoukuId="XOTEzMDA2NTA4",Url="http://player.youku.com/embed/XOTEzMDA2NTA4", Rank=2, Customer="Youku", UpdateTime=new DateTime(2015,1,1)}
            
            
            };

            videos.ForEach(x => context.Videos.Add(x));
            context.SaveChanges();

        }

    }
}