using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpBigHomework.Models;

namespace Novel_Read
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tag tag = new Tag("现代都市");
            Webservice.createTag(tag);

            Book book = new Book("都市潇洒人生传", "不是鱼是谁", "现代都市", "独行杀手猛影，回归都市平静生活。可金子到哪里总是会发光，虽然他不爱美，可美女却总是接踵而至，金钱地位也纷纷向他袭来……");
            book.PublishTime = new DateTime(2021, 6, 29, 9, 20, 35);
            Post post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 0;
            Webservice.createBook(book);

            book = new Book("都市极品医尊", "熠恺", "现代都市", "一代医尊，渡劫期间被仇家联手导致陨落。 不死不灭的神魂重生到了一个落魄的实习医生身上。 从此，开启了一条以医证道之路，争取再回巅峰！");
            book.PublishTime = new DateTime(2021, 6, 29, 18, 29, 30);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 23;
            Webservice.createBook(book);

            book = new Book("我种田就能修仙", "左手吃鸡", "现代都市", "种田＋修仙＋无敌文 李三思作为狗神传承的拥有者，为了能成功修成那传说中的仙人，只好按照那狗神笔记所言开启修仙之路。 从此，种田种出大宝贝，养鱼养成“金龙鱼”，山里的猴子对他笑，地里的小鸭哇哇叫，寻宝鼠在河里游泳都能给我整来宝贝，无聊的时候就去溜溜狗或者被狗遛。");
            book.PublishTime = new DateTime(2021, 6, 28, 5, 1, 20);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 64;
            Webservice.createBook(book);

            book = new Book("众界世主", "贝狄", "现代都市", "那是一场梦，一场救世主的梦。 梦中，我掌控“无行”驰骋沙场，无数异界神器、法宝显露峥嵘。 元素、神话、自然、传说……万界奥妙；战争、灾祸、入侵……众界无主。 梦醒，生界五职势力锋芒皆现，只为破限探外，添元涨魔，直至—— 众民称我为“救世之主”。 原来，梦里的一切，都是真的。");
            book.PublishTime = new DateTime(2021, 5, 26, 5, 9, 15);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 27;
            Webservice.createBook(book);

            tag = new Tag("励志成功");
            Webservice.createTag(tag);
            book = new Book("静音键", "蒲小平", "励志成功", "一部以西部残疾农妇奋斗故事为蓝本的励志自传性小说。女主人公身患残疾，没有考大学，学了裁缝手艺，自力更生，却不幸孩子失聪，接二连三的变故让她措手不及，受尽百般艰辛和屈辱，可她没有放弃生活的信心，陪伴孩子艰难成长。女主角在一个贫困又残疾的家庭里挣扎拼命，为改变命运不断做着各种努力，但又不得不忙于眼前，不断陷入“贫困陷阱”，而她一次次证明活着就要奋斗，让生活更美好。");
            book.PublishTime = new DateTime(2021, 3, 3, 9, 20, 35);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 3;
            Webservice.createBook(book);

            book = new Book("人脉关系课", "曾仕强", "励志成功", "人际关系本来是中性的，无所谓好坏。现代人很喜欢说话，却大多不善于沟通。许多人掉进“我有话要说”的陷阱，死都不知道是怎么死的!尽管中国人十分讲道理，但中国人的道理通常是相对的。所以，中国人常常陷入“先说先死，不说也死”的尴尬境地。为此，必须在先说和不说之间找到一个平衡点，实现安全、有效、合理的沟通，以期达到“说到不死”的境界。");
            book.PublishTime = new DateTime(2021, 1, 23, 14, 50, 1);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 71;
            Webservice.createBook(book);

            book = new Book("语言的艺术", "许荣富", "励志成功", "卡耐基毕生致力的事业造福了许许多多的人，但可以用一句话总结，那就是，帮助人们掌握“有效说话和影响他人的技巧”。他的训练班以此而命名，他的著作也为此而写。本书是卡耐基语言艺术的全集，汇集了卡耐基关于沟通、公开讲话、与听众产生共鸣、如何有效演讲等众多内容。只要你能善用本书中的技巧，一定能使你在公司、政府机关、民间组织和家庭中，踌躇满志，卓越出众。");
            book.PublishTime = new DateTime(2021, 5, 29, 16, 21, 21);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 59;
            Webservice.createBook(book);

            book = new Book("送子进清华", "孙朦", "励志成功", "高考不仅是一场知识的比拼、一次选择人生的考试，更是一场心理和智慧的较量。高考之战是无声的、残酷的，使每一位考生及其家长都承受着巨大的考验与压力。也许你拥有非凡的智慧、骄人的口才以及丰富的阅历，但当你的孩子面临考题疑惑不解时，当孩子身体不适、对高考失去信心……");
            book.PublishTime = new DateTime(2021, 4, 21, 20, 37, 58);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 100;
            Webservice.createBook(book);

            tag = new Tag("童话寓言");
            Webservice.createTag(tag);
            book = new Book("林莽之书", "刘荣跃", "童话寓言", "本书是一本难得的青少年读物，也是一本体裁新颖的童话体小说。故事从一名印度小男孩由于意外而被老虎追赶跳进了森林，却糊里糊涂的又被公狼救下开始。从此，他就在广阔的丛林中进行着他多姿多彩的生活……");
            book.PublishTime = new DateTime(2021, 5, 3, 9, 20, 35);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 3;
            Webservice.createBook(book);

            book = new Book("灰色童话书", "曹顺发", "童话寓言", "小朋友们好!想和哈里·波特一样吗？知道英国小朋友都在看什么书吗？嘘!这个秘密我可从不轻易告诉别人。记清楚啦，是安德鲁·兰爷爷的十二色童话。想认识美丽的仙女吗？想学神奇魔法吗？想和王子去打巨人吗……小心，有可怕的食人妖和大飞龙!不多说了，还等什么--欢迎来到安德鲁·兰的彩色神奇世界!");
            book.PublishTime = new DateTime(2021, 4, 23, 19, 30, 5);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 54;
            Webservice.createBook(book);

            book = new Book("少年奇侠", "郭昊", "童话寓言", "少年侦探林浩浩，少林小子白白和乖乖女秦笑笑组成了少年奇侠三人组，在一次意外之中，龙神王之子酷贝贝因为学业不精，被意外地传送到了林浩浩的家，成为了第四位少年奇侠。在一次集体去北京旅游的过程中，秦笑笑的父亲却突然昏迷不醒，是传说中的生肖诅咒悄然袭来。无尽的地宫，会飞的棺材，复活的尸骨，消失的国宝……");
            book.PublishTime = new DateTime(2021, 2, 12, 4, 9, 25);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 12;
            Webservice.createBook(book);

            book = new Book("机械大师", "陈心昭", "童话寓言", "泽兰从小生活在贫民窟，无人知道在他瘦小且左腿略有残疾的身体下隐藏着无与伦比的科学天赋。扮猪吃老虎是泽兰最爱的招数，可惜由他自己创造的武器镰刀黑可可在关键时刻总会掉链子，比如战斗到一半就迈着机械短腿跑去玩耍……高贵的身世、俊朗的外表以及开朗率真的性格，令贵族少年司徒生成为当之无愧的天之骄子。不过年幼时的一场火灾，让他的身体除了大脑外超过百分之九十五都换成了机械。命运给予的最大恩惠，就是让两个不同世界的异类相遇。当科学小怪才遇见等同于拥有自我意识的机械人，又会发生怎样有趣的故事呢？");
            book.PublishTime = new DateTime(2021, 1, 2, 13, 29, 45);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 34;
            Webservice.createBook(book);

            tag = new Tag("社科科普");
            Webservice.createTag(tag);
            book = new Book("玉华帛彩", "冯玉雷", "社科科普", "沟通中国与域外的交通网络主要由西北和西南两个陆路网络、陆海相衔的东北网络与海洋网络四大交通板块构成，主要工具是骆驼、舟楫和马帮。德国地理学家李希霍芬统称为“丝绸之路”。而作为我国古代祭祀、会盟、朝聘等所用的珍贵礼品的美玉和束帛具有更久远的东西文化交流历史。");
            book.PublishTime = new DateTime(2021, 1, 25, 7, 13, 32);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 71;
            Webservice.createBook(book);

            book = new Book("中国百科一点通", "王斌", "社科科普", "这里有科学知识、奥秘悬疑；这里有名著故事、生物趣闻……敬爱的读者，打开您面前的这套书，您会发现您的选择没有遗憾。本书在内容上涵盖了“科学技术”、“自然环境”、“人类社会”、“文化艺术”等各领域的知识：在时间上跨越了从人类茹毛饮血的蛮荒时期到科技信息高度发达的今天。");
            book.PublishTime = new DateTime(2021, 3, 1, 13, 13, 21);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 10;
            Webservice.createBook(book);

            book = new Book("别为小事烦心", "化雨", "社科科普", "你是否因为没钱买房子，没钱买车，没钱给自己和亲人买好看的衣服，还有因为一点点小事情和家人吵架，或为自己鼻上的这块小疤发过愁……可是，这些令人发愁的事情，在遇到生命危险的时候，显得那么荒谬、渺小，那时的你应该对自己说：如果我还能有机会看见明天的太阳，我永远也不会再为那些小事烦恼了。在这短暂的人生中，记住不要浪费时间去为小事烦恼。");
            book.PublishTime = new DateTime(2021, 6, 5, 2, 16, 57);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 39;
            Webservice.createBook(book);

            book = new Book("中国梦·复兴路", "卢洁", "社科科普", "作为献礼十九大重点主题出版物，本书系中国出版集团“中国梦”重点书系《中国梦·复兴路》（三卷本）原创精编版。全书以中国革命、建设、改革三大主题为线索，以重大历史事件和重要人物为脉络，用现代视角和国际化视野，全景式追溯了中华民族170多年来的强国之梦，回顾和梳理自鸦片战争到十八大以后中国发展的历史进程，并围绕中国梦主题，展现中华民族伟大复兴之历程，阐述全球视野下中国发展道路之抉择。");
            book.PublishTime = new DateTime(2021, 5, 4, 16, 28, 19);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 19;
            Webservice.createBook(book);

            tag = new Tag("现代言情");
            Webservice.createTag(tag);
            book = new Book("明月当空照", "流年记返", "现代言情", "华丽的房间里一个身着婚纱的女孩，看着化妆台上的照片忍不住哭了起来，可嘴角任挂着微笑，她喃喃细语道:“月月我和刘宇在一起了，今天我结婚了。你也会祝福我对吗？”，泪眼朦胧中她仿佛又看见那个像光一样的女孩。 如果说刘宇是顾嫣人生中的一束光照亮她的世界，那么慕明月就是……");
            book.PublishTime = new DateTime(2021, 3, 18, 11, 42, 41);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 42;
            Webservice.createBook(book);

            book = new Book("惟独宠溺", "人尹", "现代言情", "顾医生：“你是让我嗑药了吗，为什么我越来越离不开你？！” 陆总裁：“想让我帮你？代价不高，你自己就足够了” 林律师：“你是不是个傻子，遇事不知道用法？” 高老师：“谁惹你了，告诉我，我看他体育课不想过了！” 『本文一对一，无固定男女主，身心干净可放心食用๛ก(ｰ̀ωｰ́ก) 』");
            book.PublishTime = new DateTime(2021, 2, 6, 13, 28, 1);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 49;
            Webservice.createBook(book);

            book = new Book("诚难情尽", "灼僧", "现代言情", "秦淮以为这辈子就是独自活成斗战剩佛，没想到那个儿时就被自己一眼看上的人回来了，这一次可不是自己先动的手，但是……");
            book.PublishTime = new DateTime(2021, 5, 13, 17, 59, 16);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 80;
            Webservice.createBook(book);

            book = new Book("失语时代", "柔祺", "现代言情", "“这不是最好的时代，这个时代的人也算不上善良，所以我不接受他们的道歉，我要他们永远都记住我，他们都是杀死我的凶手。”——江语 “在这个无法发声的时代，江语不是第一个受害者，也不会是最后一个，她用自己的死亡来传达这个世界对她的不公，而我要做的，就是让大家记住她，记住那个骄傲的江语，世界欠她的，我来还给她。”——孟谌南");
            book.PublishTime = new DateTime(2021, 2, 6, 19, 29, 43);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 13;
            Webservice.createBook(book);

            tag = new Tag("铁血军事");
            Webservice.createTag(tag);
            book = new Book("清江东流", "郭大国", "铁血军事", "这是一个记录神奇之地上的神奇儿女抵抗日寇的故事。小说融合了鄂西南地区的历史沿革、地域风情、民俗民风等独特灿烂的文明文化及神奇的山川地貌，以广阔的视野和纵深的思考书写了恩施抗战史上的一段传奇，塑造了赵药神巴儿、覃清江等一批英雄人物，让人不禁对那片神奇的土地充满了向往之情，也使小说多了一股清新馥郁的乡土气息，突出表现了在风云变幻的时代背景下社会底层人物的信仰和命运。");
            book.PublishTime = new DateTime(2021, 2, 14, 17, 48, 32);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 5;
            Webservice.createBook(book);

            book = new Book("天地共一春", "彭承忠", "铁血军事", "本书以抗日战争时期的武陵山区为背景，揭示这一特殊时期西南某少数民族地区的各种社会矛盾及百姓的生存状态，国难当头，土家族、苗族同胞为求生存，自发组织武装力量，保境安民，各类民变队伍应运而生。");
            book.PublishTime = new DateTime(2021, 1, 13, 20, 31, 15);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 15;
            Webservice.createBook(book);

            book = new Book("雪狼行动", "江公", "铁血军事", "夜幕垂落，华灯齐放，国家体育场人头攒动，大赛即将开幕，可是，一个鬼魅般的人影挤进了人群，他就是身揣炸弹的章晗，一头最凶狠、无知、野蛮的雪狼，一个视生命为无谓的人体炸弹，一个被恐怖组织洗脑的杀人工具……一切如箭在弦上，一切让人窒息，恐怖如黑色的夜幕一样缓缓而落，威胁出现在所有人身旁，谁也不知道下一分钟会发生什么……");
            book.PublishTime = new DateTime(2021, 4, 7, 16, 37, 19);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 55;
            Webservice.createBook(book);

            book = new Book("血性", "李西闽", "铁血军事", "太阳还没有露面，白军就发起了第一波进攻。白军炮兵用榴弹炮和山炮还有迫击炮向红军阵地狂轰乱炸，这个美好的清晨被炸得支离破碎。在炮火的掩护下，白军朝我们阵地发起冲锋。我把盒子枪插在了腰间的皮带上，端起了一支三八步枪，对着冲上来的白军瞄准……");
            book.PublishTime = new DateTime(2021, 2, 25, 3, 34, 29);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 25;
            Webservice.createBook(book);

            tag = new Tag("悬疑小说");
            Webservice.createTag(tag);
            book = new Book("控制木偶", "梦川", "悬疑小说", "一个古老的传说，揭开了一个又一个的悲伤故事。卷在这场风暴中间的苏沫，将如何解开一个又一个的谜团？");
            book.PublishTime = new DateTime(2021, 6, 1, 8, 53, 10);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 85;
            Webservice.createBook(book);

            book = new Book("雾雨", "伊洛离", "悬疑小说", "我被亲生母亲绑架到了一座小岛上，在那里，我九死一生，最后却被一陌生男子救了，本以为我终于能回归现实生活了，可没想到这只是刚刚开始……");
            book.PublishTime = new DateTime(2021, 5, 31, 19, 3, 27);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 65;
            Webservice.createBook(book);

            book = new Book("时间缝隙", "放让", "悬疑小说", "【悬疑＋无限】 十年前的一天，父亲像往常一样出门上班，却再也没有回来。父亲神秘失踪了。由于父亲物理研究所首席研究员的特殊身份，他的神秘失踪被怀疑是绑架甚至叛逃，他所研究的机密项目面临着泄密风险。 十年后的一天，冷子非像平日一样去物理所上班，然后他就发现，自己穿越了。他的手机被换成了一部跟手机长得一样的“时间机器”，从此他掌握了时间机器的使用，在时空间来去自如。 有一天，“时间机器”突然显示出一条信息：“我被困在时间缝隙。” 冷子非：爸，是你吗！ 父亲到底被卷入了一场怎样的阴谋？ 冷子非开始了一连串的暗访。他始终没有忘记他的本心：找到父亲。是不是穿越回去就能让父亲不再失踪？ 想要安稳生活的人被卷入谋局，想要掌控世界的人被戳破泡沫，你有你的患得患失，我有我的运筹帷幄。 时间黑洞面前，来来往往，不过皆是漩涡下的幻梦。");
            book.PublishTime = new DateTime(2021, 4, 8, 7, 23, 15);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 29;
            Webservice.createBook(book);

            book = new Book("民间诡谈", "大小姐丫头", "悬疑小说", "我有个爷爷叫刘一手，是个扎纸匠，在颠覆了我人生认知的一晚过后，爷爷和爸爸同时失踪了，我等来的，是一个年轻漂亮的姑娘，带我离开了生我养我的村子。从那时起，我才知道，我，命里五弊三缺，霉运当头……，后来我渐渐的发现，原来刘一手真的留了不止一手。");
            book.PublishTime = new DateTime(2021, 1, 3, 11, 54, 29);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 95;
            Webservice.createBook(book);

            tag = new Tag("浪漫青春");
            Webservice.createTag(tag);
            book = new Book("喜欢在等你", "橘红", "浪漫青春", "【淡然骄矜男主VS温和狡黠女主】 说好的高冷自持，不近女色呢？ 赶着凑上去是几个意思？ 众人皆知，D大经管院的慕嘉言无论家世还是外貌，都堪称完美，大学三年来洁身自好，当同学们都以为他会就这样一直下去，直到毕业。 但是他身边突现出现的女孩是谁？还是个大一新生？ 只有慕嘉言自己知道，他等这一天等了有多久？久到他以为就这样了…… 上天还是偏爱他，将她送到了他的身边。 这是一个关于高中暗恋多年却没有机会开口，在大学相遇，而后相爱的故事。 高甜、轻松校园、专撒糖、天作之合。");
            book.PublishTime = new DateTime(2021, 4, 28, 21, 10, 6);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 109;
            Webservice.createBook(book);

            book = new Book("浪漫量产", "弄里大叔", "浪漫青春", "丑小鸭逆袭白天鹅记。遇见金铭轩的那个午后，张艺清刚从食堂出来，刚走近洗手台梧桐树叶就飘落。男孩干净的校服笔挺的站在树下，他的手指夹着一片枯黄的落叶，半眯着好像在享受这个季节。这一幕直击女孩眼中，在女孩眼中留下了，一幅美丽的画卷。舒适的季节，充满画意的场景，让人流连忘返啊！");
            book.PublishTime = new DateTime(2021, 3, 17, 9, 16, 46);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 10;
            Webservice.createBook(book);

            book = new Book("蔷薇的刺", "姜福贵", "浪漫青春", "一个小镇，两个紧密但又疏离的灵魂。 　　他常常词不达意，她常常欲言又止。 　　他以为他表现的足够明显，她以为是她靠得太近。 　　一段隐晦，克制，深刻，明亮的双向暗恋，她是否真的来过他的世界。 　　后来，隔着朋友的手机，他对她说，“谢谢，你好。” 　　后来，一次命运安排的重逢·····");
            book.PublishTime = new DateTime(2021, 5, 21, 19, 34, 47);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 76;
            Webservice.createBook(book);

            book = new Book("心少年狂", "枯心", "浪漫青春", "一个准备毕业的准高三学生，在面对爱情的问题上究竟会有怎样的抉择……");
            book.PublishTime = new DateTime(2021, 1, 31, 9, 28, 16);
            post = new Post("空白", "标题", book.TagName, null);
            post.NextId = new List<string>();
            post.Readers = 0;
            Webservice.createPost(post);
            book.FirstPage = post.PostId;
            book.Readers = 34;
            Webservice.createBook(book);

            User user = new User("root", 'm', "root");
            user.FavorList = new List<string>();
            Webservice.createUser(user);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLogin());
        }
    }
}
