﻿using Shadowsocks.Controller;
using Sweet.LoveWinne.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class RegistryForm : Form
    {
        private readonly UpdateServerListClient _updateServerListClient;
        private List<QuestionDto> _questionDtoList = new List<QuestionDto>();

        public bool RegisrySuccess { get; set; }

        public RegistryForm(UpdateServerListClient updateServerListClient)
            : this()
        {
            this._updateServerListClient = updateServerListClient;
        }

        public RegistryForm()
        {
            InitializeComponent();
        }

        private void InitQuestionList()
        {
            var response = _updateServerListClient.GetQuestionList(null);
            if (response.IsSuccess)
            {
                _questionDtoList = response.QuestionList;
            }
        }
    }
}