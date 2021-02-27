using System;

namespace FlowTimer {

    class FF7Util {
        public static readonly string[] CHOCO_NAMES = {
            "SAM",
            "ELEN",
            "BLUES",
            "TOM",
            "JOHN",
            "GARY",
            "MIKE",
            "SANDY",
            "JU",
            "LY",
            "JOEL",
            "GREY",
            "EDWARD",
            "JAMES",
            "HARVEY",
            "DAN",
            "RUDY",
            "GRAHAM",
            "FOX",
            "CLIVE",
            "SEAN",
            "YOUNG",
            "ROBIN",
            "DARIO",
            "ARL",
            "SARA",
            "MARIE",
            "SAMMY",
            "LIA",
            "KNIGHT",
            "PAULA",
            "PAU",
            "LE",
            "PETER",
            "AIMEE",
            "TERRY",
            "ANDY",
            "NANCY",
            "TIM",
            "ROBER",
            "GEORGE",
            "JENNY",
            "RICA",
            "JULIA"
        };

        public static readonly string[] ITEM_NAMES = {
            "Sprint Shoes",
            "Counter Attack",
            "Magic Counter",
            "Precious Watch",
            "Cat's Bell",
            "Enemy Away",
            "Sneak Attack",
            "Chocobracelet",
            "Ether",
            "Elixir",
            "Hero Drink",
            "Bolt Plume",
            "Fire Fang",
            "Antarctic Wind",
            "Swift Bolt",
            "Fire Veil",
            "Ice Crystal",
            "Megalixir",
            "Turbo Ether",
            "Potion",
            "Phoenix Down",
            "Hyper",
            "Tranquilizer",
            "Hi-Potion"
        };

        public static readonly byte[][][] REWARD_TABLES = {
            new byte[][]{ // C
                new byte[]{0x17, 0x00, 0x05, 0x01},
                new byte[]{0x08, 0x00, 0x14, 0x01},
                new byte[]{0x15, 0x00, 0x0A, 0x00},
                new byte[]{0x16, 0x00, 0x0A, 0x00},
                new byte[]{0x14, 0x00, 0x14, 0x00},
                new byte[]{0x0B, 0x00, 0x05, 0x01},
                new byte[]{0x0C, 0x00, 0x05, 0x00},
                new byte[]{0x0D, 0x00, 0x05, 0x00},
                new byte[]{0x13, 0x00, 0x05, 0x01},
                new byte[]{0x14, 0x00, 0x14, 0x01},
            }, new byte[][] { // B
                new byte[]{0x08, 0x00, 0x1E, 0x00},
                new byte[]{0x0A, 0x00, 0x0A, 0x00},
                new byte[]{0x14, 0x00, 0x14, 0x00},
                new byte[]{0x12, 0x00, 0x05, 0x01},
                new byte[]{0x08, 0x00, 0x1E, 0x00},
                new byte[]{0x17, 0x00, 0x05, 0x00},
                new byte[]{0x15, 0x00, 0x0A, 0x00},
                new byte[]{0x16, 0x00, 0x0A, 0x00},
                new byte[]{0x17, 0x00, 0x05, 0x00},
                new byte[]{0x0B, 0x00, 0x0A, 0x01},
                new byte[]{0x0C, 0x00, 0x0A, 0x00},
                new byte[]{0x0D, 0x00, 0x0A, 0x00},
                new byte[]{0x09, 0x00, 0x0A, 0x01},
                new byte[]{0x05, 0x01, 0x05, 0x01},
                new byte[]{0x17, 0x00, 0x05, 0x00},
            }, new byte[][] { // A
                new byte[]{0x08, 0x00, 0x14, 0x00},
                new byte[]{0x0A, 0x00, 0x0A, 0x00},
                new byte[]{0x0E, 0x01, 0x0A, 0x00},
                new byte[]{0x0F, 0x01, 0x0A, 0x00},
                new byte[]{0x0C, 0x00, 0x0A, 0x00},
                new byte[]{0x10, 0x01, 0x0A, 0x00},
                new byte[]{0x01, 0x00, 0x0A, 0x01},
                new byte[]{0x05, 0x01, 0x05, 0x01},
                new byte[]{0x0B, 0x00, 0x0A, 0x00},
                new byte[]{0x0C, 0x00, 0x0A, 0x00},
                new byte[]{0x0D, 0x00, 0x0A, 0x00},
                new byte[]{0x09, 0x00, 0x0A, 0x01},
                new byte[]{0x17, 0x00, 0x05, 0x00},
                new byte[]{0x08, 0x00, 0x14, 0x00},
                new byte[]{0x00, 0x01, 0x07, 0x01},
                new byte[]{0x09, 0x00, 0x05, 0x01},
                new byte[]{0x14, 0x00, 0x14, 0x00},
                new byte[]{0x0C, 0x00, 0x0A, 0x00},
                new byte[]{0x04, 0x01, 0x07, 0x01},
                new byte[]{0x06, 0x01, 0x07, 0x01},
            }, new byte[][] { // S
                new byte[]{0x12, 0x01, 0x05, 0x00},
                new byte[]{0x0A, 0x00, 0x05, 0x00},
                new byte[]{0x09, 0x00, 0x05, 0x01},
                new byte[]{0x01, 0x00, 0x05, 0x01},
                new byte[]{0x05, 0x01, 0x05, 0x01},
                new byte[]{0x06, 0x01, 0x05, 0x01},
                new byte[]{0x0E, 0x01, 0x05, 0x00},
                new byte[]{0x0F, 0x01, 0x05, 0x00},
                new byte[]{0x0B, 0x00, 0x02, 0x00},
                new byte[]{0x0F, 0x01, 0x05, 0x00},
                new byte[]{0x14, 0x00, 0x14, 0x00},
                new byte[]{0x10, 0x00, 0x05, 0x00},
                new byte[]{0x11, 0x01, 0x05, 0x01},
                new byte[]{0x12, 0x00, 0x05, 0x00},
                new byte[]{0x00, 0x01, 0x05, 0x01},
                new byte[]{0x0E, 0x00, 0x05, 0x00},
                new byte[]{0x04, 0x01, 0x05, 0x01},
                new byte[]{0x09, 0x00, 0x05, 0x01},
                new byte[]{0x07, 0x01, 0x05, 0x01},
                new byte[]{0x10, 0x01, 0x05, 0x00},
                new byte[]{0x03, 0x01, 0x05, 0x01},
                new byte[]{0x02, 0x01, 0x05, 0x01},
            }
        };
        public class RNG {
            public uint rngState;
            public int rngIncrs;

            const int a = 0x41C64E6D;
            const int b = 0x3039;
            public RNG(uint seed = 0) {
                this.rngState = seed;
                this.rngIncrs = 0;
            }

            public uint rng() {
                rngIncrs++;
                rngState = (a * rngState + b);
                return (rngState >> 0x10) & 0x7FFF;
            }
        }

        public struct ChocoboData {
            public uint[] items;
            public uint[] tileCards;
            public uint[] names;

            public ChocoboData(uint[] items, uint[] tileCards, uint[] names) {
                this.items = items;
                this.tileCards = tileCards;
                this.names = names;
            }
        }

        public static bool frameMatches(int frame, uint[] items, uint[] names, char rank = 'C') {
            ChocoboData data = generateChocoboRaceData(new RNG((uint) frame), rank);
            for(int i = 0; i < items.Length; i++) {
                if(data.items[i] != items[i]) {
                    return false;
                }
            }
            for(int i = 0; i < names.Length; i++) {
                if(data.names[i] != names[i]) {
                    return false;
                }
            }
            return true;
        }

        public static int offsetToNearestMatchingFrame(int frame, uint[] items, uint[] names, char rank = 'C') {

            if(frameMatches(frame, items, names, rank)) {
                return 0;
            }

            for(int i = 1; i < 6000; i += 1) {
                if(frameMatches(frame - i, items, names, rank)) {
                    return -i;
                }
                if(frameMatches(frame + i, items, names, rank)) {
                    return i;
                }
            }

            return int.MaxValue;
        }

        public static ChocoboData generateChocoboRaceData(RNG rng = null, char rank = 'C', uint _B747C = 0xffffffff) {
            if(rng == null) {
                rng = new RNG();
            }

            uint frame = rng.rngState;

            for(int i = 0; i < 0x28; i++) {
                rng.rng();
                rng.rng();
            }
            rng.rng();
            for(int i = 0; i < 5; i++) {
                rng.rng();
                rng.rng();
                rng.rng();
                rng.rng();
                rng.rng();
                rng.rng();
            }
            uint[] names = new uint[43];
            for(uint i = 0; i < names.Length; i++) {
                names[i] = i;
            }
            long hilo = 0L;
            uint v0, v1, s0, s1, s2, s3, t2, t7, a0, a1, a2;

            s1 = 0;
            s3 = 0x2FA0BE83;
            while(s1 < 0xC8) {
                s1 += 1;
                v0 = rng.rng();
                hilo = ((long) v0 * (long) s3);
                t2 = (uint) (hilo >> 32);
                v1 = v0 >> 0x1F;
                a0 = t2 >> 3;
                s0 = a0 - v1;
                v1 = s0 << 1;
                v1 += s0;
                v1 = v1 << 2;
                v1 -= s0;
                v1 = v1 << 2;
                v1 -= s0;
                s0 = v0 - v1;

                uint swap1 = s0;

                v0 = rng.rng();
                hilo = ((long) v0 * (long) s3);
                t2 = (uint) (hilo >> 32);
                v1 = v0 >> 0x1F;
                a0 = t2 >> 3;
                a0 -= v1;
                v1 = a0 << 1;
                v1 += a0;
                v1 = v1 << 2;
                v1 -= a0;
                v1 = v1 << 2;
                v1 -= a0;
                a0 = v0 - v1;

                uint swap2 = a0;

                a0 = names[swap2];
                a1 = names[swap1];
                names[swap1] = a0;
                names[swap2] = a1;
            }

            int rankNum = -1;
            switch(rank) {
                case 'C':
                case 'c':
                    rankNum = 0;
                    break;
                case 'B':
                case 'b':
                    rankNum = 1;
                    break;
                case 'A':
                case 'a':
                    rankNum = 2;
                    break;
                case 'S':
                case 's':
                    rankNum = 3;
                    break;
            }

            byte[][] rewardTable = REWARD_TABLES[rankNum];
            byte[] rewardPool = { 0xFF, 0xFF, 0xFF };

            s1 = 0;
            s2 = 0;
            s3 = 0xffffffff;

            while(s1 != 3) {
                v0 = rng.rng() % (uint) rewardTable.Length;
                byte[] item = rewardTable[v0];
                if(rewardPool[0] == item[0] || rewardPool[1] == item[1] || rewardPool[2] == item[2]) {
                    continue;
                }
                if(rewardTable[v0][1] != 0) {
                    if(s2 != 0) {
                        if(item[3] != 0) {
                            continue;
                        }
                    }
                    if(_B747C != 0) {
                        rewardPool[s1] = item[0];
                        s1 += 1;
                    }
                    if(rewardTable[v0][3] == 0) {
                        continue;
                    }
                    s3 = item[0];
                    s2 = 0xfffffff;
                    continue;
                }
                if(s2 != 0) {
                    if(rewardTable[v0][3] != 0) {
                        continue;
                    }
                }
                rewardPool[s1] = item[0];
                s1 += 1;
                if(rewardTable[v0][3] == 0) {
                    continue;
                }
                s3 = item[0];
                s2 = 0xffffffff;
            }

            Array.Sort(rewardPool);

            if(s3 != 0xffffffff) {
                if(rewardPool[0] == s3) {
                    v0 = rewardPool[2];
                    rewardPool[2] = (byte) s3;
                    rewardPool[0] = (byte) v0;
                } else if(rewardPool[1] == s3) {
                    v0 = rewardPool[2];
                    rewardPool[2] = (byte) s3;
                    rewardPool[1] = (byte) v0;
                }
            }

            uint[] tileBufferItems = new uint[15];
            uint[] tileBufferCards = new uint[15];
            for(int i = 0; i < 7; i++) {
                tileBufferItems[i] = rewardPool[0];
                tileBufferCards[i] = 0;
            }
            for(int i = 7; i < 12; i++) {
                tileBufferItems[i] = rewardPool[1];
                tileBufferCards[i] = 1;
            }
            for(int i = 12; i < 12 + 3; i++) {
                tileBufferItems[i] = rewardPool[2];
                tileBufferCards[i] = 2;
            }

            s1 = 0;
            s3 = 0x88888889;
            long s3l = -0x77777777;

            while(s1 < 100) {
                s1 += 2;
                v0 = rng.rng();
                a0 = v0 >> 0x1F;
                hilo = ((long) v0 * s3l);
                t7 = (uint) (hilo >> 32);
                v1 = (t7 + v0) >> 3;
                s0 = v1 - a0;
                v1 = s0 << 4;
                v1 = v1 - s0;
                s0 = v0 - v1;

                uint swap1 = s0;

                v0 = rng.rng();
                hilo = ((long) v0 * s3l);
                t7 = (uint) (hilo >> 32);
                a0 = v0 >> 0x1F;

                a2 = tileBufferItems[swap1];
                v1 = (t7 + v0) >> 3;
                a0 = v1 - a0;
                v1 = a0 << 4;
                v1 -= a0;
                a0 = v0 - v1;

                uint swap2 = a0;

                v0 = tileBufferItems[swap2];
                tileBufferItems[swap1] = v0;
                v0 = tileBufferCards[swap2];
                tileBufferItems[swap2] = a2;
                a2 = tileBufferCards[swap1];
                tileBufferCards[swap1] = v0;
                tileBufferCards[swap2] = a2;

                v0 = rng.rng();
                hilo = ((long) v0 * s3l);
                t7 = (uint) (hilo >> 32);
                a0 = v0 >> 0x1F;
                v1 = (t7 + v0) >> 3;
                s0 = v1 - a0;
                v1 = s0 << 4;
                v1 -= s0;
                s0 = v0 - v1;

                swap1 = s0;

                v0 = rng.rng();
                hilo = ((long) v0 * s3l);
                t7 = (uint) (hilo >> 32);
                a2 = tileBufferItems[s0];
                v1 = (t7 + v0) >> 3;
                a0 = v1 - a0;
                v1 = a0 << 4;
                v1 -= a0;
                a0 = v0 - v1;

                swap2 = a0;

                v0 = tileBufferItems[swap2];
                tileBufferItems[swap1] = v0;
                v0 = tileBufferCards[swap2];
                tileBufferItems[swap2] = a2;
                a2 = tileBufferCards[swap1];
                tileBufferCards[swap1] = v0;
                tileBufferCards[swap2] = a2;
            }

            uint[] rewardPoolUint = new uint[rewardPool.Length];
            for(int i = 0; i < rewardPool.Length; i++) {
                rewardPoolUint[i] = (uint) rewardPool[i];
            }

            uint[] namesOut = new uint[5];
            for(int i = 0; i < 5; i++) {
                namesOut[i] = names[i + 1];
            }

            return new ChocoboData(rewardPoolUint, tileBufferCards, namesOut);
        }
    }
}
