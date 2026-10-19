using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class CreateOrderGCashForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlCategoryTabs = new System.Windows.Forms.Panel();
            this.btnCatMLBB = new System.Windows.Forms.Button();
            this.btnCatGames = new System.Windows.Forms.Button();
            this.btnCatVoucher = new System.Windows.Forms.Button();
            this.btnCatEntertainment = new System.Windows.Forms.Button();
            this.pnlItemCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGCash = new System.Windows.Forms.Panel();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.lblSelectedPrice = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.txtGameUserId = new System.Windows.Forms.TextBox();
            this.pnlMerchant = new System.Windows.Forms.Panel();
            this.lblGCashMerchant = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtGCashRef = new System.Windows.Forms.TextBox();
            this.lblProof = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picReceiptPreview = new System.Windows.Forms.PictureBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();

            this.pnlCategoryTabs.SuspendLayout();
            this.pnlGCash.SuspendLayout();
            this.pnlMerchant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceiptPreview)).BeginInit();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(425, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "🎮 Choose Game / Service & Buy with GCash";

            // pnlCategoryTabs
            this.pnlCategoryTabs.Controls.Add(this.btnCatMLBB);
            this.pnlCategoryTabs.Controls.Add(this.btnCatGames);
            this.pnlCategoryTabs.Controls.Add(this.btnCatVoucher);
            this.pnlCategoryTabs.Controls.Add(this.btnCatEntertainment);
            this.pnlCategoryTabs.Location = new System.Drawing.Point(20, 48);
            this.pnlCategoryTabs.Name = "pnlCategoryTabs";
            this.pnlCategoryTabs.Size = new System.Drawing.Size(530, 36);
            this.pnlCategoryTabs.TabIndex = 1;

            // btnCatMLBB
            this.btnCatMLBB.BackColor = SwevenColors.DarkPink;
            this.btnCatMLBB.FlatAppearance.BorderSize = 0;
            this.btnCatMLBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatMLBB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatMLBB.ForeColor = System.Drawing.Color.White;
            this.btnCatMLBB.Location = new System.Drawing.Point(0, 2);
            this.btnCatMLBB.Name = "btnCatMLBB";
            this.btnCatMLBB.Size = new System.Drawing.Size(125, 32);
            this.btnCatMLBB.TabIndex = 0;
            this.btnCatMLBB.Text = "🌸 MLBB";
            this.btnCatMLBB.UseVisualStyleBackColor = false;
            this.btnCatMLBB.Click += new System.EventHandler(this.BtnCategory_Click);

            // btnCatGames
            this.btnCatGames.BackColor = System.Drawing.Color.White;
            this.btnCatGames.FlatAppearance.BorderSize = 0;
            this.btnCatGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatGames.ForeColor = SwevenColors.TextColor;
            this.btnCatGames.Location = new System.Drawing.Point(132, 2);
            this.btnCatGames.Name = "btnCatGames";
            this.btnCatGames.Size = new System.Drawing.Size(125, 32);
            this.btnCatGames.TabIndex = 1;
            this.btnCatGames.Text = "🎮 Games";
            this.btnCatGames.UseVisualStyleBackColor = false;
            this.btnCatGames.Click += new System.EventHandler(this.BtnCategory_Click);

            // btnCatVoucher
            this.btnCatVoucher.BackColor = System.Drawing.Color.White;
            this.btnCatVoucher.FlatAppearance.BorderSize = 0;
            this.btnCatVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatVoucher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatVoucher.ForeColor = SwevenColors.TextColor;
            this.btnCatVoucher.Location = new System.Drawing.Point(264, 2);
            this.btnCatVoucher.Name = "btnCatVoucher";
            this.btnCatVoucher.Size = new System.Drawing.Size(125, 32);
            this.btnCatVoucher.TabIndex = 2;
            this.btnCatVoucher.Text = "🎟️ Voucher";
            this.btnCatVoucher.UseVisualStyleBackColor = false;
            this.btnCatVoucher.Click += new System.EventHandler(this.BtnCategory_Click);

            // btnCatEntertainment
            this.btnCatEntertainment.BackColor = System.Drawing.Color.White;
            this.btnCatEntertainment.FlatAppearance.BorderSize = 0;
            this.btnCatEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatEntertainment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatEntertainment.ForeColor = SwevenColors.TextColor;
            this.btnCatEntertainment.Location = new System.Drawing.Point(396, 2);
            this.btnCatEntertainment.Name = "btnCatEntertainment";
            this.btnCatEntertainment.Size = new System.Drawing.Size(132, 32);
            this.btnCatEntertainment.TabIndex = 3;
            this.btnCatEntertainment.Text = "📱 Entertainment";
            this.btnCatEntertainment.UseVisualStyleBackColor = false;
            this.btnCatEntertainment.Click += new System.EventHandler(this.BtnCategory_Click);

            // pnlItemCards
            this.pnlItemCards.AutoScroll = true;
            this.pnlItemCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemCards.Location = new System.Drawing.Point(20, 90);
            this.pnlItemCards.Name = "pnlItemCards";
            this.pnlItemCards.Size = new System.Drawing.Size(530, 545);
            this.pnlItemCards.TabIndex = 2;

            // pnlGCash
            this.pnlGCash.BackColor = System.Drawing.Color.White;
            this.pnlGCash.Controls.Add(this.lblStep2);
            this.pnlGCash.Controls.Add(this.lblSelectedProduct);
            this.pnlGCash.Controls.Add(this.lblSelectedPrice);
            this.pnlGCash.Controls.Add(this.lblGame);
            this.pnlGCash.Controls.Add(this.txtGameUserId);
            this.pnlGCash.Controls.Add(this.pnlMerchant);
            this.pnlGCash.Controls.Add(this.lblRef);
            this.pnlGCash.Controls.Add(this.txtGCashRef);
            this.pnlGCash.Controls.Add(this.lblProof);
            this.pnlGCash.Controls.Add(this.btnUpload);
            this.pnlGCash.Controls.Add(this.picReceiptPreview);
            this.pnlGCash.Controls.Add(this.btnSubmitOrder);
            this.pnlGCash.Location = new System.Drawing.Point(565, 48);
            this.pnlGCash.Name = "pnlGCash";
            this.pnlGCash.Padding = new System.Windows.Forms.Padding(18);
            this.pnlGCash.Size = new System.Drawing.Size(475, 587);
            this.pnlGCash.TabIndex = 3;

            // lblStep2
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStep2.ForeColor = SwevenColors.DarkPink;
            this.lblStep2.Location = new System.Drawing.Point(15, 12);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(232, 20);
            this.lblStep2.TabIndex = 0;
            this.lblStep2.Text = "2. Enter Details & GCash Payment";

            // lblSelectedProduct
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedProduct.ForeColor = SwevenColors.TextColor;
            this.lblSelectedProduct.Location = new System.Drawing.Point(15, 45);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(306, 17);
            this.lblSelectedProduct.TabIndex = 1;
            this.lblSelectedProduct.Text = "Selected: None (Please click an item on the left)";

            // lblSelectedPrice
            this.lblSelectedPrice.AutoSize = true;
            this.lblSelectedPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedPrice.ForeColor = SwevenColors.DarkPink;
            this.lblSelectedPrice.Location = new System.Drawing.Point(15, 70);
            this.lblSelectedPrice.Name = "lblSelectedPrice";
            this.lblSelectedPrice.Size = new System.Drawing.Size(147, 21);
            this.lblSelectedPrice.TabIndex = 2;
            this.lblSelectedPrice.Text = "Amount Due: ₱0.00";

            // lblGame
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGame.Location = new System.Drawing.Point(15, 105);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(262, 15);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "Game User ID / Server (e.g. 12345678 (2001)):";

            // txtGameUserId
            this.txtGameUserId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGameUserId.Location = new System.Drawing.Point(15, 125);
            this.txtGameUserId.Name = "txtGameUserId";
            this.txtGameUserId.Size = new System.Drawing.Size(440, 24);
            this.txtGameUserId.TabIndex = 4;

            // pnlMerchant
            this.pnlMerchant.BackColor = SwevenColors.MainPink;
            this.pnlMerchant.Controls.Add(this.lblGCashMerchant);
            this.pnlMerchant.Location = new System.Drawing.Point(15, 160);
            this.pnlMerchant.Name = "pnlMerchant";
            this.pnlMerchant.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMerchant.Size = new System.Drawing.Size(440, 65);
            this.pnlMerchant.TabIndex = 5;

            // lblGCashMerchant
            this.lblGCashMerchant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGCashMerchant.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGCashMerchant.ForeColor = SwevenColors.TextColor;
            this.lblGCashMerchant.Location = new System.Drawing.Point(10, 10);
            this.lblGCashMerchant.Name = "lblGCashMerchant";
            this.lblGCashMerchant.Size = new System.Drawing.Size(420, 45);
            this.lblGCashMerchant.TabIndex = 0;
            this.lblGCashMerchant.Text = "📱 GCash Merchant Details:\nNumber: 0917-888-9999 (Sweven\'s Market Official)\nSend via Express Send & save your Reference Number.";

            // lblRef
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRef.ForeColor = SwevenColors.TextColor;
            this.lblRef.Location = new System.Drawing.Point(15, 235);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(248, 15);
            this.lblRef.TabIndex = 6;
            this.lblRef.Text = "Enter 13-Digit GCash Reference Number *";

            // txtGCashRef
            this.txtGCashRef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGCashRef.Location = new System.Drawing.Point(15, 255);
            this.txtGCashRef.Name = "txtGCashRef";
            this.txtGCashRef.PlaceholderText = "e.g. 1002345678901";
            this.txtGCashRef.Size = new System.Drawing.Size(440, 25);
            this.txtGCashRef.TabIndex = 7;

            // lblProof
            this.lblProof.AutoSize = true;
            this.lblProof.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProof.Location = new System.Drawing.Point(15, 290);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(225, 15);
            this.lblProof.TabIndex = 8;
            this.lblProof.Text = "Attach Payment Screenshot (Optional):";

            // btnUpload
            this.btnUpload.BackColor = SwevenColors.MainPink;
            this.btnUpload.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(15, 310);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(140, 30);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "📎 Browse Image...";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);

            // picReceiptPreview
            this.picReceiptPreview.BackColor = SwevenColors.LightGray;
            this.picReceiptPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReceiptPreview.Location = new System.Drawing.Point(165, 310);
            this.picReceiptPreview.Name = "picReceiptPreview";
            this.picReceiptPreview.Size = new System.Drawing.Size(290, 80);
            this.picReceiptPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReceiptPreview.TabIndex = 10;
            this.picReceiptPreview.TabStop = false;

            // btnSubmitOrder
            this.btnSubmitOrder.BackColor = SwevenColors.DarkPink;
            this.btnSubmitOrder.FlatAppearance.BorderSize = 0;
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(15, 405);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(440, 45);
            this.btnSubmitOrder.TabIndex = 11;
            this.btnSubmitOrder.Text = "🚀 SUBMIT ORDER & GCASH PAYMENT";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);

            // CreateOrderGCashForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.pnlGCash);
            this.Controls.Add(this.pnlItemCards);
            this.Controls.Add(this.pnlCategoryTabs);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateOrderGCashForm";
            this.Text = "Create Order";
            this.pnlCategoryTabs.ResumeLayout(false);
            this.pnlGCash.ResumeLayout(false);
            this.pnlGCash.PerformLayout();
            this.pnlMerchant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReceiptPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlCategoryTabs;
        private System.Windows.Forms.Button btnCatMLBB;
        private System.Windows.Forms.Button btnCatGames;
        private System.Windows.Forms.Button btnCatVoucher;
        private System.Windows.Forms.Button btnCatEntertainment;
        private System.Windows.Forms.FlowLayoutPanel pnlItemCards;
        private System.Windows.Forms.Panel pnlGCash;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblSelectedProduct;
        private System.Windows.Forms.Label lblSelectedPrice;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.TextBox txtGameUserId;
        private System.Windows.Forms.Panel pnlMerchant;
        private System.Windows.Forms.Label lblGCashMerchant;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtGCashRef;
        private System.Windows.Forms.Label lblProof;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox picReceiptPreview;
        private System.Windows.Forms.Button btnSubmitOrder;
    }
}
