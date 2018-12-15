using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerewolfClient
{
    public class RuleModel : Model
    {
        public const string SEER = "Seer";
        public const string AURA_SEER = "Aura Seer";
        public const string PRIEST = "Priest";
        public const string DOCTOR = "Doctor";
        public const string WEREWOLF = "Werewolf";
        public const string WEREWOLF_SHAMAN = "Werewolf Sharman";
        public const string ALPHA_WEREWOLF = "Alpha Werewolf";
        public const string WEREWOLF_SEER = "Werewolf Seer";
        public const string MEDIUM = "Medium";
        public const string BODYGUARD = "Bodyguard";
        public const string JAILER = "Jailer";
        public const string FOOL = "Fool";
        public const string HEAD_HUNTER = "Head Hunter";
        public const string SERIAL_KILLER = "Serial Killer";
        public const string GUNNER = "Gunner";

        private const string RULE_SEER = "ความสามารถ : ในแต่ละคืน คุณสามารถส่องคนอื่นได้ว่าเขาเป็นใคร\r\n\t" +
            "คาแรคเตอร์นี้เป็นผู้ที่ฝั่งชาวบ้านต้องปกป้องให้ดีและเชื่อ Seer เสมอ";
        private const string RULE_AURA_SEER = "ควาสามารถ : ในแต่ละคืน Aura Seer จะสามารถส่องผู้เล่นคนอื่นได้แต่จะไม่ชัดเท่า\r\n " +
            "\tSeer เพราะ Aura Seer จะทราบแค่ ฝ่ายดี ฝ่ายร้าย และไม่ทราบฝ่าย";
        private const string RULE_PRIEST = "ความสามารถ : พระคนนี้มีน้ำมนต์ และน้ำมนต์นี่ล่ะสาดหมาป่าตาย\r\n " +
            "\tแต่ถ้าคุณสาดมั่วใส่คนที่ไม่ใช่หมาป่าคุณจะตายเอง";
        private const string RULE_DOCTOR = "ความสามารถ : เลือกปกป้องผู้เล่น 1 คน\r\n" +
            "\tในตอนกลางคืนเพื่อไม่ให้เขาตาย";
        private const string RULE_WEREWOLF = "ความสามารถ : คุณสามารถเลือกฆ่าเหยื่อในตอนกลางคืนตามผลโหวตในกลุ่มหมาป่า คุณมี 1แต้มในการเลือกโหวตในคืนนั้นๆ";
        private const string RULE_WEREWOLF_SHAMAN = "ความสามารถ : ในตอนกลางวันสามารถร่ายเวทย์ใส่คนอื่นได้ ทำให้คนที่คุณร่ายใส่ถูกมองเห็นเป็นมนุษย์หมาป่า \r\n" +
            "\tเมื่อพวกที่สามารถส่องได้อย่าง Seer และ Aura Seer ส่องคนที่คุณร่ายเวทย์ใส่ก็จะพบว่าคนนั้นเป็นฝ่ายหมาป่า\r\n " +
            "\tถ้าคุณคือหมาป่าตัวสุดท้ายจะไม่สามารถร่ายเวทย์ได้ แต่สามารถฆ่าคนได้ในตอนกลางคืนแบบหมาป่าปกติ";
        private const string RULE_ALPHA_WEREWOLF = "ความสามารถ : คุณคือผู้นำเหล่าหมาป่าเมื่อผลโหวตฆ่าในตอนกลางคืนมีคะแนนเท่ากัน คะแนนโหวตของคุณคือ 2 แต้ม";
        private const string RULE_WEREWOLF_SEER = "ความสามารถ : ในตอนกลางคืน คุณสามารถดูบทบาทของคนที่คุณเลือกได้ 1 คน ว่าเขาเป็นใครแล้วแจ้งเพื่อนหมาคุณเลือกฆ่าได้เลย\r\n" +
            "\tแต่ถ้าคุณเหลือเป็นหมาป่าคนสุดท้ายคุณจะเป็นแค่หมาธรรมดาคนนึงเลือกฆ่าได้ตามปกติ";
        private const string RULE_MEDIUM = "ความสามารถ : ในตอนกลางคืนคุณสามารถคุยกับคนที่ตายไปแล้วได้แบบไม่เปิดเผยตัวตน\r\n" +
            "\tและคุณสามารถชุบชีวิตได้ 1 ครั้งเท่านั้น โดยปกติแล้วจะเลือกชุบ Seerหรือ Gunnerและ Doctor";
        private const string RULE_BODYGUARD = "ความสามารถ : การ์ดจะสามารถปกป้องผู้เล่น 1 คน\r\n" +
            "\tได้ในคืนนั้นๆ ผู้เล่นคนนั้นจะไม่ถูกฆ่า\r\n" +
            "\tแต่คุณจะโดนโจมตีแทน คุณจะไม่เป็นไรในคืนแรกเพราะคุณแข็งแกร่งมาก \r\n" +
            "\tแต่ถ้าคุณโดนโจมตีอีกครั้งคุณจะตาย ที่สำคัญบอดี้การ์ดจะปกป้องตัวเองอัตโนมัติ";
        private const string RULE_JAILER = "ความสามารถ : ในตอนกลางวันคุณสามารถเลือกผู้เล่น 1 คนเพื่อคุมขัง เมื่อถึงตอนกลางคืน\r\n " +
            "\tคุณสามารถพูดคุยกับคนที่คุณคุมขังเป็นการส่วนตัว และนักโทษจะไม่สามารถใช้สกิลในคืนนั้นๆได้\r\n " +
            "\tถ้านักโทษที่คุณสงสัยว่าเป้นฝ่ายร้าย คุณสามารถฆ่าเขาได้เลย ";
        private const string RULE_FOOL = "ความสามารถ : หน้าที่เดียวของคนบ้าคือทำยังไงก็ได้ให้คนเขาโหวตคุณ ถ้าเขาโหวตประหารคุณ คุณจะชนะทันที";
        private const string RULE_HEAD_HUNTER = "ความสามารถ : คุณต้องทำให้เป้าหมายโดนแขวนคอประหารจากชาวบ้าน ถ้าเป้าหมายของคุณตายด้วยวิธีอื่น คุณจะกลายเป็นชาวบ้านธรรมดา";
        private const string RULE_SERIAL_KILLER = "ความสามารถ : ในแต่ละคืน คุณมีมีดสามารถเลือกฆ่าได้คืนละ 1 คน ถ้าคุณรอดเป็นคนสุดท้าย คุณจะชนะ \r\n" +
            "\tและที่สำคัญในตอนกลางคืนคุณจะไม่โดนหมาป่าฆ่าอีกด้วย ";
        private const string RULE_GUNNER = "ความสามารถ : เป็นดาบสองคมเลยครับคาแรคเตอร์นี้ โดยคุณมีกระสุนเพียง 2 นัด\r\n " +
            "\tเมื่อคุณยิงไปแล้วนัดแรก คุณจะถูกเปิดเผยตัวตนทันทีว่าคุณคือ มือปืน ";

        private string lblShowRule;

        public RuleModel()
        {
            lblShowRule = null;
        }

        public void setShowRule(string character)
        {
            switch (character)
            {
                case SEER :
                    lblShowRule = RULE_SEER;
                    break;
                case AURA_SEER:
                    lblShowRule = RULE_AURA_SEER;
                    break;
                case PRIEST:
                    lblShowRule = RULE_PRIEST;
                    break;
                case DOCTOR:
                    lblShowRule = RULE_DOCTOR;
                    break;
                case WEREWOLF:
                    lblShowRule = RULE_WEREWOLF;
                    break;
                case RULE_WEREWOLF_SHAMAN:
                    lblShowRule = RULE_WEREWOLF_SHAMAN;
                    break;
                case ALPHA_WEREWOLF:
                    lblShowRule = RULE_ALPHA_WEREWOLF;
                    break;
                case WEREWOLF_SEER:
                    lblShowRule = RULE_WEREWOLF_SEER;
                    break;
                case MEDIUM:
                    lblShowRule = RULE_MEDIUM;
                    break;
                case BODYGUARD:
                    lblShowRule = RULE_BODYGUARD;
                    break;
                case JAILER:
                    lblShowRule = RULE_JAILER;
                    break;
                case FOOL:
                    lblShowRule = RULE_FOOL;
                    break;
                case HEAD_HUNTER:
                    lblShowRule = RULE_HEAD_HUNTER;
                    break;
                case SERIAL_KILLER:
                    lblShowRule = RULE_SERIAL_KILLER;
                    break;
                case GUNNER:
                    lblShowRule = RULE_GUNNER;
                    break;

            }
            NotifyAll();
        }

    }
}
