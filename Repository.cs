using SQLite;
using WS.Campaigns;
using WS.Campaigns.Characters.Action;
using WS.Campaigns.Characters.BonusAction;
using WS.Campaigns.Characters.Character;
using WS.Campaigns.Characters.Stat;
using WS.Campaigns.Items.Armour;
using WS.Campaigns.Items.Consumable;
using WS.Campaigns.Items.Tool;
using WS.Campaigns.Items.Trinket;
using WS.Campaigns.Items.Weapon;
using WS.Campaigns.Zones.Location;
using WS.Campaigns.Zones.Zone;

namespace WS
{
    public class Repository
    {
        string _dbPath; // DB file path

        public string StatusMessage { get; set; }

        private SQLiteAsyncConnection conn;

        /*
         * If no database found, initialise and create tables.
         */
        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<CampaignModel>();
            await conn.CreateTableAsync<ZoneModel>();
            await conn.CreateTableAsync<LocationModel>();
            await conn.CreateTableAsync<Campaigns.Zones.Map>();
            await conn.CreateTableAsync<CharacterModel>();
            await conn.CreateTableAsync<StatModel>();
            await conn.CreateTableAsync<ActionModel>();
            await conn.CreateTableAsync<BonusActionModel>();
            await conn.CreateTableAsync<ArmourModel>();
            await conn.CreateTableAsync<ConsumableModel>();
            await conn.CreateTableAsync<ToolModel>();
            await conn.CreateTableAsync<TrinketModel>();
            await conn.CreateTableAsync<WeaponModel>();
        }

        public Repository(string dbPath)
        {
            _dbPath = dbPath;
        }

        /*
         * Add a new campaign.
         */
        public async Task AddNewCampaign(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid campaign name must be entered.");

                result = await conn.InsertAsync(
                    new CampaignModel { Identifiers = new Identifiers() { Name = name, Description = description} });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all campaigns.
         */
        public async Task<List<CampaignModel>> GetAllCampaigns()
        {
            try
            {
                await Init();
                return await conn.Table<CampaignModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<CampaignModel>();
        }

        /*
         * Delete a campaign.
         */
        public async Task DeleteCampaign(int id)
        {
            int result = 0;
            try
            {
                await Init();

                CampaignModel campaign = await conn.Table<CampaignModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = campaign.GetName();

                result = await conn.DeleteAsync(campaign);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new zone.
         */
        public async Task AddNewZone(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid zone name must be entered.");

                result = await conn.InsertAsync(
                    new ZoneModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all zones.
         */
        public async Task<List<ZoneModel>> GetAllZones()
        {
            try
            {
                await Init();
                return await conn.Table<ZoneModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<ZoneModel>();
        }

        /*
         * Delete a zone.
         */
        public async Task DeleteZone(int id)
        {
            int result = 0;
            try
            {
                await Init();

                ZoneModel zone = await conn.Table<ZoneModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = zone.GetName();

                result = await conn.DeleteAsync(zone);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new location.
         */
        public async Task AddNewLocation(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid location name must be entered.");

                result = await conn.InsertAsync(
                    new LocationModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all locations.
         */
        public async Task<List<LocationModel>> GetAllLocations()
        {
            try
            {
                await Init();

                return await conn.Table<LocationModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }
            return new List<LocationModel>();
        }

        /*
         * Delete a location.
         */
        public async Task DeleteLocation(int id)
        {
            int result = 0;
            try
            {
                await Init();

                LocationModel location = await conn.Table<LocationModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = location.GetName();

                result = await conn.DeleteAsync(location);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new character.
         */
        public async Task AddNewCharacter(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid character name must be entered.");

                result = await conn.InsertAsync(
                    new CharacterModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all characters.
         */
        public async Task<List<CharacterModel>> GetAllCharacters()
        {
            try
            {
                await Init();
                return await conn.Table<CharacterModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<CharacterModel>();
        }

        /*
         * Delete a character.
         */
        public async Task DeleteCharacter(int id)
        {
            int result = 0;
            try
            {
                await Init();

                CharacterModel character = await conn.Table<CharacterModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = character.GetName();

                result = await conn.DeleteAsync(character);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new stat.
         */
        public async Task AddNewStat(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid stat name must be entered.");

                result = await conn.InsertAsync(
                    new StatModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all stats.
         */
        public async Task<List<StatModel>> GetAllStats()
        {
            try
            {
                await Init();
                return await conn.Table<StatModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<StatModel>();
        }

        /*
         * Delete a stat.
         */
        public async Task DeleteStat(int id)
        {
            int result = 0;
            try
            {
                await Init();

                StatModel stat = await conn.Table<StatModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = stat.GetName();

                result = await conn.DeleteAsync(stat);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new action.
         */
        public async Task AddNewAction(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid action name must be entered.");

                result = await conn.InsertAsync(
                    new ActionModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all actions.
         */
        public async Task<List<ActionModel>> GetAllActions()
        {
            try
            {
                await Init();
                return await conn.Table<ActionModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<ActionModel>();
        }

        /*
         * Delete an action.
         */
        public async Task DeleteAction(int id)
        {
            int result = 0;
            try
            {
                await Init();

                ActionModel action = await conn.Table<ActionModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = action.GetName();

                result = await conn.DeleteAsync(action);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new bonus action.
         */
        public async Task AddNewBonusAction(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid bonus action name must be entered.");

                result = await conn.InsertAsync(
                    new BonusActionModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all bonus actions.
         */
        public async Task<List<BonusActionModel>> GetAllBonusActions()
        {
            try
            {
                await Init();
                return await conn.Table<BonusActionModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<BonusActionModel>();
        }

        /*
         * Delete a bonus action.
         */
        public async Task DeleteBonusAction(int id)
        {
            int result = 0;
            try
            {
                await Init();

                BonusActionModel bonusAction = await conn.Table<BonusActionModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = bonusAction.GetName();

                result = await conn.DeleteAsync(bonusAction);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new armour.
         */
        public async Task AddNewArmour(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid armour name must be entered.");

                result = await conn.InsertAsync(
                    new ArmourModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all armour.
         */
        public async Task<List<ArmourModel>> GetAllArmour()
        {
            try
            {
                await Init();
                return await conn.Table<ArmourModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<ArmourModel>();
        }

        /*
         * Delete an armour.
         */
        public async Task DeleteArmour(int id)
        {
            int result = 0;
            try
            {
                await Init();

                ArmourModel armour = await conn.Table<ArmourModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = armour.GetName();

                result = await conn.DeleteAsync(armour);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new consumable.
         */
        public async Task AddNewConsumable(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid consumable name must be entered.");

                result = await conn.InsertAsync(
                    new ConsumableModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all consumables.
         */
        public async Task<List<ConsumableModel>> GetAllConsumables()
        {
            try
            {
                await Init();
                return await conn.Table<ConsumableModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<ConsumableModel>();
        }

        /*
         * Delete a consumable.
         */
        public async Task DeleteConsumable(int id)
        {
            int result = 0;
            try
            {
                await Init();

                ConsumableModel consumable = await conn.Table<ConsumableModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = consumable.GetName();

                result = await conn.DeleteAsync(consumable);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new tool.
         */
        public async Task AddNewTool(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid tool name must be entered.");

                result = await conn.InsertAsync(
                    new ToolModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all tools.
         */
        public async Task<List<ToolModel>> GetAllTools()
        {
            try
            {
                await Init();
                return await conn.Table<ToolModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<ToolModel>();
        }

        /*
         * Delete a tool.
         */
        public async Task DeleteTool(int id)
        {
            int result = 0;
            try
            {
                await Init();

                ToolModel tool = await conn.Table<ToolModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = tool.GetName();

                result = await conn.DeleteAsync(tool);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new trinket.
         */
        public async Task AddNewTrinket(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid trinket name must be entered.");

                result = await conn.InsertAsync(
                    new TrinketModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all trinkets.
         */
        public async Task<List<TrinketModel>> GetAllTrinkets()
        {
            try
            {
                await Init();
                return await conn.Table<TrinketModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<TrinketModel>();
        }

        /*
         * Delete a trinket.
         */
        public async Task DeleteTrinket(int id)
        {
            int result = 0;
            try
            {
                await Init();

                TrinketModel trinket = await conn.Table<TrinketModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = trinket.GetName();

                result = await conn.DeleteAsync(trinket);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }

        /*
         * Add a new weapon.
         */
        public async Task AddNewWeapon(string name, string description = "")
        {
            int result = 0;
            try
            {
                await Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("A valid weapon name must be entered.");

                result = await conn.InsertAsync(
                    new WeaponModel { Identifiers = new Identifiers() { Name = name, Description = description } });

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not add {0}. Error: {1}", name, ex.Message);
            }
        }

        /*
         * Get a list of all weapons.
         */
        public async Task<List<WeaponModel>> GetAllWeapons()
        {
            try
            {
                await Init();
                return await conn.Table<WeaponModel>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Data retrieval failed. {0}", ex.Message);
            }

            return new List<WeaponModel>();
        }

        /*
         * Delete a weapon.
         */
        public async Task DeleteWeapon(int id)
        {
            int result = 0;
            try
            {
                await Init();

                WeaponModel weapon = await conn.Table<WeaponModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
                string name = weapon.GetName();

                result = await conn.DeleteAsync(weapon);

                StatusMessage = string.Format("{0} record(s) deleted (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Could not delete {0}. Error: {1}", id, ex.Message);
            }
        }
    }
}