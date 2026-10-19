using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class CreateOrderGCashForm : Form
    {
        private string activeCategory = "MLBB";
        private string uploadedProofPath = "";
        private Product? selectedProduct = null;
        private string currentFieldName = "Mobile Legends User ID & Zone ID";

        public CreateOrderGCashForm()
        {
            InitializeComponent();
            SetDefaultFieldForCategory("MLBB");
            LoadCategoryItems();
        }

        private void LoadCategoryItems()
        {
            pnlItemCards.SuspendLayout();
            pnlItemCards.Controls.Clear();

            var items = DataStore.Products
                .Where(p => p.Category.Equals(activeCategory, StringComparison.OrdinalIgnoreCase) && p.Status == "Active")
                .ToList();

            if (items.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = $"🌸 No active products under {activeCategory} right now! 💕",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = SwevenColors.TextGray,
                    AutoSize = false,
                    Size = new Size(500, 100),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlItemCards.Controls.Add(lblEmpty);
            }
            else
            {
                foreach (var product in items)
                {
                    pnlItemCards.Controls.Add(CreateProductCard(product));
                }
            }

            pnlItemCards.ResumeLayout();
        }

        private Control CreateProductCard(Product p)
        {
            bool isSelected = selectedProduct?.Id == p.Id;

            var card = new CuteCardPanel
            {
                Size = new Size(250, 78),
                Margin = new Padding(0, 0, 10, 10),
                BackColor = isSelected ? ColorTranslator.FromHtml("#FFF0F5") : Color.White,
                CardBorderColor = isSelected ? SwevenColors.DarkPink : ColorTranslator.FromHtml("#FCE7F3"),
                BorderRadius = 12,
                Cursor = Cursors.Hand
            };

            var lblName = new Label
            {
                Text = p.Name,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = isSelected ? SwevenColors.DarkPink : SwevenColors.TextColor,
                Location = new Point(12, 10),
                AutoSize = true,
                Cursor = Cursors.Hand
            };

            var lblDesc = new Label
            {
                Text = p.Description,
                Font = new Font("Segoe UI", 7.8F),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(12, 30),
                Size = new Size(225, 16),
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            var lblPrice = new Label
            {
                Text = $"₱ {p.Price:N2}",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(12, 48),
                AutoSize = true,
                Cursor = Cursors.Hand
            };

            void SelectThisProduct()
            {
                selectedProduct = p;
                lblSelectedProduct.Text = $"🌸 Selected: {p.Name} ({p.Category}) 💖";
                lblSelectedPrice.Text = $"✨ Amount Due: ₱{p.Price:N2}";
                UpdateTargetFieldForProduct(p);
                LoadCategoryItems(); // Refresh cards to highlight active one
            }

            card.Click += (s, e) => SelectThisProduct();
            lblName.Click += (s, e) => SelectThisProduct();
            lblDesc.Click += (s, e) => SelectThisProduct();
            lblPrice.Click += (s, e) => SelectThisProduct();

            card.Controls.Add(lblName);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblPrice);

            return card;
        }

        private void SetDefaultFieldForCategory(string category)
        {
            if (category == "MLBB")
            {
                currentFieldName = "Mobile Legends User ID & Zone ID";
                lblGame.Text = "🎮 Mobile Legends User ID & Zone ID:";
                txtGameUserId.PlaceholderText = "e.g. 12345678 (3001)";
                lblFieldHint.Text = "💡 Find in MLBB Profile (e.g. User ID: 12345678, Server: 3001).";
            }
            else if (category == "Games")
            {
                currentFieldName = "In-Game User ID / Player Account";
                lblGame.Text = "🎮 In-Game User ID / Player Account:";
                txtGameUserId.PlaceholderText = "e.g. Player UID, Riot ID, or Account Username";
                lblFieldHint.Text = "💡 Provide your player account details for credit delivery.";
            }
            else if (category == "Voucher")
            {
                currentFieldName = "Email / Discord Tag";
                lblGame.Text = "📧 Delivery Email / Discord (for voucher code):";
                txtGameUserId.PlaceholderText = "e.g. yourname@gmail.com or username#0001";
                lblFieldHint.Text = "💡 Voucher PIN code or gift link will be delivered here.";
            }
            else if (category == "Entertainment")
            {
                currentFieldName = "Mobile Phone / App Username";
                lblGame.Text = "📱 Mobile Number / App Username:";
                txtGameUserId.PlaceholderText = "e.g. 0917-123-4567 or @telegram_username";
                lblFieldHint.Text = "💡 Mobile load or app stars will be sent straight to this account.";
            }
        }

        private void UpdateTargetFieldForProduct(Product p)
        {
            txtGameUserId.Clear();

            if (p.Category == "MLBB")
            {
                currentFieldName = "Mobile Legends User ID & Zone ID";
                lblGame.Text = "🎮 Mobile Legends User ID & Zone ID:";
                txtGameUserId.PlaceholderText = "e.g. 12345678 (3001)";
                lblFieldHint.Text = "💡 Find in MLBB Profile (e.g. User ID: 12345678, Zone ID: 3001).";
            }
            else if (p.Category == "Games")
            {
                if (p.Name.Contains("Valorant", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Riot Games ID & Tagline";
                    lblGame.Text = "🎯 Riot ID & Tagline:";
                    txtGameUserId.PlaceholderText = "e.g. PlayerName#PH1";
                    lblFieldHint.Text = "💡 Enter your full Riot Games ID with hashtag tagline.";
                }
                else if (p.Name.Contains("Roblox", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Roblox Username";
                    lblGame.Text = "🧱 Roblox Username:";
                    txtGameUserId.PlaceholderText = "e.g. RobloxGamer2026";
                    lblFieldHint.Text = "💡 Enter your exact Roblox account username.";
                }
                else if (p.Name.Contains("Genshin", StringComparison.OrdinalIgnoreCase) || p.Name.Contains("Honkai", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "HoYoverse In-Game UID & Server";
                    lblGame.Text = "✨ HoYoverse In-Game UID & Server:";
                    txtGameUserId.PlaceholderText = "e.g. 801234567 (Asia Server)";
                    lblFieldHint.Text = "💡 Shown on the bottom-right corner of your game screen.";
                }
                else if (p.Name.Contains("Call of Duty", StringComparison.OrdinalIgnoreCase) || p.Name.Contains("CODM", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "CODM Player UID";
                    lblGame.Text = "🔫 Call of Duty Mobile Player UID:";
                    txtGameUserId.PlaceholderText = "e.g. 67489230119283";
                    lblFieldHint.Text = "💡 Found in your CODM Basic Profile tab.";
                }
                else if (p.Name.Contains("Free Fire", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Free Fire Player UID";
                    lblGame.Text = "🔥 Free Fire Player UID:";
                    txtGameUserId.PlaceholderText = "e.g. 1928374650";
                    lblFieldHint.Text = "💡 Found in your Garena Free Fire Profile.";
                }
                else if (p.Name.Contains("Point Blank", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Zepetto Point Blank Login ID";
                    lblGame.Text = "💥 Zepetto Point Blank Login ID:";
                    txtGameUserId.PlaceholderText = "e.g. PBGamerPH";
                    lblFieldHint.Text = "💡 Enter your Zepetto Point Blank account username.";
                }
                else
                {
                    currentFieldName = "In-Game User ID / Account";
                    lblGame.Text = "🎮 In-Game User ID / Character Name:";
                    txtGameUserId.PlaceholderText = "e.g. Player Account ID";
                    lblFieldHint.Text = "💡 Enter your character ID or player account name.";
                }
            }
            else if (p.Category == "Voucher")
            {
                if (p.Name.Contains("Discord", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Discord Username or Tag";
                    lblGame.Text = "💬 Discord Username or Tag:";
                    txtGameUserId.PlaceholderText = "e.g. gamer_girl or user#0001";
                    lblFieldHint.Text = "💡 Subscription gift link will be sent to your Discord/History.";
                }
                else
                {
                    currentFieldName = "Delivery Email Address";
                    lblGame.Text = "📧 Delivery Email Address (Digital Voucher Pin):";
                    txtGameUserId.PlaceholderText = "e.g. yourname@gmail.com";
                    lblFieldHint.Text = "💡 Your electronic redeemable voucher PIN will be sent here.";
                }
            }
            else if (p.Category == "Entertainment")
            {
                if (p.Name.Contains("Load", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Prepaid Mobile Number";
                    lblGame.Text = "📱 Prepaid Mobile Number (to receive load):";
                    txtGameUserId.PlaceholderText = "e.g. 0917-123-4567 or 0919-888-9999";
                    lblFieldHint.Text = "💡 Regular airtime load will be credited straight to this number.";
                }
                else if (p.Name.Contains("Telegram", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Telegram Username or Phone Number";
                    lblGame.Text = "✈️ Telegram Username or Phone Number:";
                    txtGameUserId.PlaceholderText = "e.g. @your_username or +639171234567";
                    lblFieldHint.Text = "💡 Telegram Stars will be gifted directly to this username.";
                }
                else if (p.Name.Contains("Bigo", StringComparison.OrdinalIgnoreCase) || p.Name.Contains("Litmatch", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "Live App User ID";
                    lblGame.Text = "🎤 Live App User ID (Bigo / Litmatch):";
                    txtGameUserId.PlaceholderText = "e.g. 88991122";
                    lblFieldHint.Text = "💡 Found on your app profile page under your avatar.";
                }
                else if (p.Name.Contains("DramaBox", StringComparison.OrdinalIgnoreCase))
                {
                    currentFieldName = "DramaBox Account Email or User ID";
                    lblGame.Text = "📺 DramaBox Account Email or User ID:";
                    txtGameUserId.PlaceholderText = "e.g. dramabox_user@gmail.com";
                    lblFieldHint.Text = "💡 1-Month VIP pass will be activated for this streaming account.";
                }
                else
                {
                    currentFieldName = "Recipient Account / Phone / Email";
                    lblGame.Text = "📱 Recipient Account / Phone / Email:";
                    txtGameUserId.PlaceholderText = "e.g. Account identifier";
                    lblFieldHint.Text = "💡 Enter the account where service should be activated.";
                }
            }
        }

        private void BtnCategory_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn == btnCatMLBB) activeCategory = "MLBB";
                else if (btn == btnCatGames) activeCategory = "Games";
                else if (btn == btnCatVoucher) activeCategory = "Voucher";
                else if (btn == btnCatEntertainment) activeCategory = "Entertainment";

                // Reset all category buttons
                btnCatMLBB.BackColor = Color.White;
                btnCatMLBB.ForeColor = SwevenColors.TextColor;
                btnCatGames.BackColor = Color.White;
                btnCatGames.ForeColor = SwevenColors.TextColor;
                btnCatVoucher.BackColor = Color.White;
                btnCatVoucher.ForeColor = SwevenColors.TextColor;
                btnCatEntertainment.BackColor = Color.White;
                btnCatEntertainment.ForeColor = SwevenColors.TextColor;

                // Highlight active button
                btn.BackColor = SwevenColors.DarkPink;
                btn.ForeColor = Color.White;

                SetDefaultFieldForCategory(activeCategory);
                selectedProduct = null;
                lblSelectedProduct.Text = "Selected: None (Please click an item on the left)";
                lblSelectedPrice.Text = "Amount Due: ₱0.00";
                LoadCategoryItems();
            }
        }

        private void BtnUpload_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    uploadedProofPath = ofd.FileName;
                    picReceiptPreview.ImageLocation = uploadedProofPath;
                }
            }
        }

        private void BtnSubmitOrder_Click(object? sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please click on an item from the category list first! 💕", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGameUserId.Text))
            {
                MessageBox.Show($"Please enter your {currentFieldName} first! 💕", "Account Details Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGameUserId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGCashRef.Text) || txtGCashRef.Text.Trim().Length < 8)
            {
                MessageBox.Show("Please enter a valid GCash Reference Number from your SMS or screenshot! 📱", "Reference Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGCashRef.Focus();
                return;
            }

            string newOrderId = $"OR{DataStore.Orders.Count + 1:D4}";
            var newOrder = new Order
            {
                OrderId = newOrderId,
                Date = DateTime.Now,
                Customer = string.IsNullOrEmpty(UserSession.FullName) ? "Maria Santos" : UserSession.FullName,
                Product = selectedProduct.Name,
                Amount = selectedProduct.Price,
                GCashReferenceNo = txtGCashRef.Text.Trim(),
                GCashStatus = "Pending",
                OrderStatus = "Pending",
                ProofImagePath = uploadedProofPath,
                Remarks = $"{currentFieldName}: {txtGameUserId.Text.Trim()}"
            };

            DataStore.Orders.Add(newOrder);

            MessageBox.Show($"🎉 Order #{newOrderId} for {selectedProduct.Name} placed successfully!\n\n💖 GCash Ref #{newOrder.GCashReferenceNo} has been submitted for verification.\nCheck 'My Order History' to track status! ✨",
                            "Order Placed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGCashRef.Clear();
            txtGameUserId.Clear();
            picReceiptPreview.Image = null;
            uploadedProofPath = "";
            selectedProduct = null;
            lblSelectedProduct.Text = "Selected: None (Please click an item on the left)";
            lblSelectedPrice.Text = "Amount Due: ₱0.00";
            SetDefaultFieldForCategory(activeCategory);
            LoadCategoryItems();
        }
    }
}
