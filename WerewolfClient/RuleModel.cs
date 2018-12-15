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

        private const string RULE_SEER = "SEER"+"\r\nในแต่ละคืน คุณสามารถส่องคนอื่นได้ว่าเขาเป็นใคร" + "\r\n\tคาแรคเตอร์นี้เป็นผู้ที่ฝั่งชาวบ้าน"+"\n\rต้องปกป้องให้ดีและเชื่อ Seer เสมอ";
        private const string RULE_AURA_SEER = "AURA SEER"+"\r\nในแต่ละคืน Aura Seer จะสามารถส่องผู้เล่นคนอื่นได้แต่จะไม่ชัดเท่า" +
            "\r\n Seer เพราะ Aura Seer จะทราบแค่"+"\n\rฝ่ายดี ฝ่ายร้าย และไม่ทราบฝ่าย";
        private const string RULE_PRIEST = "PRIEST"+"\r\nพระคนนี้มีน้ำมนต์ และน้ำมนต์นี่ล่ะสาดหมาป่าตาย" +
            "\n\rแต่ถ้าคุณสาดมั่วใส่คนที่ไม่ใช่หมาป่าคุณจะตายเอง";
        private const string RULE_DOCTOR = "DOCTOR"+"\r\nเลือกปกป้องผู้เล่น 1 คน" +
            "\n\rในตอนกลางคืนเพื่อไม่ให้เขาตาย";
        private const string RULE_WEREWOLF = "WEREWOLF"+"\r\nคุณสามารถเลือกฆ่าเหยื่อในตอนกลางคืน"+"\n\rตามผลโหวตในกลุ่มหมาป่า คุณมี 1แต้มในการเลือกโหวตในคืนนั้นๆ";
        private const string RULE_WEREWOLF_SHAMAN = "WEREWOLF SHAMAN"+"\r\nในตอนกลางวันสามารถร่ายเวทย์ใส่คนอื่นได้"+"\n\rทำให้คนที่คุณร่ายใส่ถูกมองเห็นเป็นมนุษย์หมาป่า" +
            "\n\rเมื่อพวกที่สามารถส่องได้อย่าง Seer และ Aura Seer"+"\n\rส่องคนที่คุณร่ายเวทย์ใส่ก็จะพบว่าคนนั้นเป็นฝ่ายหมาป่า" +
            "\n\rถ้าคุณคือหมาป่าตัวสุดท้ายจะไม่สามารถร่ายเวทย์ได้"+"\n\rแต่สามารถฆ่าคนได้ในตอนกลางคืนแบบหมาป่าปกติ";
        private const string RULE_ALPHA_WEREWOLF = "ALPHA WEREWOLF"+"\r\nคุณคือผู้นำเหล่าหมาป่าเมื่อผลโหวตฆ่า"+"\n\rในตอนกลางคืนมีคะแนนเท่ากัน"+"\n\rคะแนนโหวตของคุณคือ 2 แต้ม";
        private const string RULE_WEREWOLF_SEER = "WEREWOLF SEER"+"\r\nในตอนกลางคืนคุณสามารถดูบทบาทของคนที่คุณเลือกได้ 1 คน"+"\n\rว่าเขาเป็นใครแล้วแจ้งเพื่อนหมาคุณเลือกฆ่าได้เลย" +
            "\n\rแต่ถ้าคุณเหลือเป็นหมาป่าคนสุดท้าย"+"\n\rคุณจะเป็นแค่หมาธรรมดาคนนึงเลือกฆ่าได้ตามปกติ";
        private const string RULE_MEDIUM = "MEDIUM"+"\n\rในตอนกลางคืนคุณสามารถคุยกับคนที่ตาย"+"\n\rไปแล้วได้แบบไม่เปิดเผยตัวตนและ"+"\n\rคุณสามารถชุบชีวิตได้ 1 ครั้งเท่านั้นโดยปกติแล้วจะเลือกชุบ"+"\n\rSeerหรือ Gunnerและ Doctor";
        private const string RULE_BODYGUARD = "BODYGUARD"+"\r\nการ์ดจะสามารถปกป้องผู้เล่น 1 คน" +
            "\n\rได้ในคืนนั้นๆ ผู้เล่นคนนั้นจะไม่ถูกฆ่า" +
            "\n\rแต่คุณจะโดนโจมตีแทน คุณจะไม่เป็นไรในคืนแรก"+"\n\rเพราะคุณแข็งแกร่งมาก" +
            "\n\rแต่ถ้าคุณโดนโจมตีอีกครั้งคุณจะตาย"+"\n\rที่สำคัญบอดี้การ์ดจะปกป้องตัวเองอัตโนมัติ";
        private const string RULE_JAILER = "JAILER"+"\r\nความสามารถ : ในตอนกลางวันคุณสามารถเลือกผู้เล่น 1 คน"+"\n\rเพื่อคุมขัง เมื่อถึงตอนกลางคืน" +
            "\n\rคุณสามารถพูดคุยกับคนที่คุณคุมขังเป็นการส่วนตัว"+"\n\rและนักโทษจะไม่สามารถใช้สกิลในคืนนั้นๆได้" +
            "\n\rถ้านักโทษที่คุณสงสัยว่าเป้นฝ่ายร้าย คุณสามารถฆ่าเขาได้เลย ";
        private const string RULE_FOOL = "FOOL"+"\r\nหน้าที่เดียวของคนบ้าคือทำยังไงก็ได้ให้คนเขาโหวตคุณ"+"\n\rถ้าเขาโหวตประหารคุณ คุณจะชนะทันที";
        private const string RULE_HEAD_HUNTER = "HEAD HUNTER"+"\n\rคุณต้องทำให้เป้าหมายโดนแขวนคอประหารจากชาวบ้าน"+"\n\rถ้าเป้าหมายของคุณตายด้วยวิธีอื่น คุณจะกลายเป็นชาวบ้านธรรมดา";
        private const string RULE_SERIAL_KILLER = "SERIAL KILLER"+"\n\rในแต่ละคืน คุณมีมีดสามารถเลือกฆ่าได้คืนละ 1 คน"+"\n\rถ้าคุณรอดเป็นคนสุดท้าย คุณจะชนะ" +
            "\n\rและที่สำคัญในตอนกลางคืนคุณจะไม่โดนหมาป่าฆ่าอีกด้วย ";
        private const string RULE_GUNNER = "GUNNER"+"\n\rคุณมีกระสุนเพียง 2 นัดเมื่อคุณยิงไปแล้วนัดแรก"+"\n\rคุณจะถูกเปิดเผยตัวตนทันทีว่าคุณคือ มือปืน ";

        private string lblShowRule;

        public RuleModel()
        {
            lblShowRule = "Please Select Character";
        }

        public string GetRule()
        {
            return lblShowRule;
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
                case WEREWOLF_SHAMAN:
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
